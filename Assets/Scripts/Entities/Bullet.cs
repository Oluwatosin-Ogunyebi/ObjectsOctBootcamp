using UnityEngine;

public class Bullet: MonoBehaviour
{
    [SerializeField] private float damage;
    [SerializeField] private float speed;

    private string targetTag;

    public void SetBullet(float _damage, string _targetTag, float _speed = 10.0f)
    {
        this.damage = _damage;
        this.speed = _speed;
        this.targetTag = _targetTag;
    }
    private void Update()
    {
        Move();
    }
    private void Move()
    {   
        Debug.Log($"Bullet moving to do a damage of {damage}");
        transform.Translate(Vector2.right * speed * Time.deltaTime);
    }

    private void Damage(IDamageable damageable)
    {
        if (damageable != null)
        {
            damageable.GetDamage(damage);
            Debug.Log($"Damaged Something");
            Destroy(gameObject);
        }
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Bullet collided with " + collision.gameObject.name);

        //Check the target
        if (!collision.gameObject.CompareTag(targetTag))
        {
            return;
        }



        //Using interface
        IDamageable damageable = collision.GetComponent<IDamageable>();
        Damage(damageable);
    }
}
