using UnityEngine;

public class Player: PlayableObject
{
    private string nickName;
    [SerializeField] private Camera cam;
    [SerializeField] private float speed;

    private Rigidbody2D playerRB;

    public override void Shoot()
    {
        Debug.Log($"Player is shooting a bullet");
    }

    public override void Die()
    {

    }

    private void Start()
    {
        health = new Health(100f, 100f, 0.5f);
        playerRB = GetComponent<Rigidbody2D>();
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
        Debug.Log("Player Damaged!");
    }
}
