using UnityEngine;

public class Player: PlayableObject
{
    private string nickName;
    [SerializeField] private Camera cam;
    [SerializeField] private float speed;


    [SerializeField] private float weaponDamage = 1;
    [SerializeField] private float bulletSpeed = 10.0f;
    [SerializeField] private Bullet bulletPrefab;

    private Rigidbody2D playerRB;

    public override void Shoot()
    {
        weapon.Shoot(bulletPrefab, this, "Enemy");
        Debug.Log($"Player is shooting a bullet");
    }

    public override void Die()
    {
        Debug.Log("Player is Dead");
        Destroy(this.gameObject);
    }

    private void Start()
    {
        health = new Health(100f, 100f, 0.5f);
        playerRB = GetComponent<Rigidbody2D>();
        Debug.Log("Player health value is " + health.GetHealth());
        //Set Player Weapon
        weapon =  new Weapon("Player Weapon", weaponDamage, bulletSpeed);
    }
    private void Update()
    {
        health.RegenerateHealth();
    }

    public override void Move(Vector2 direction, Vector2 target)
    {
        playerRB.velocity = direction * speed * Time.deltaTime;
        var playerScreenPos = cam.WorldToScreenPoint(transform.position);

        target.x -= playerScreenPos.x;
        target.y -= playerScreenPos.y;

        float angle = Mathf.Atan2(target.y, target.x) * Mathf.Rad2Deg;

        transform.rotation = Quaternion.Euler(0,0,angle);

        //TODO: Target and Rotation
    }

    public override void Attack(float interval)
    {

    }

    public override void GetDamage(float damage)
    {
        health.DeductHealth(damage);
        if (health.GetHealth() <= 0)
        {
            Die();
        }
        Debug.Log($"Player Damaged! Remaining Health is {health.GetHealth()}");
    }
}
