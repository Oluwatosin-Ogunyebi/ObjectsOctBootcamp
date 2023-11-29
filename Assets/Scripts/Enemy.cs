using UnityEditor.ShaderGraph.Internal;
using UnityEngine;

public class Enemy : PlayableObject
{
    private string enemyName;
    [SerializeField] private float speed;
    private EnemyType enemyType;

    protected Transform target;

    protected virtual void Start()
    {
        target = GameObject.FindWithTag("Player").transform;
    }

    protected virtual void Update()
    {
        if (target != null)
        {
            Move(target.position);
        }
        else
        {
            Move(speed);
        }
    }
    public override void Shoot()
    {   
        Debug.Log($"Shooting a bullet");
    }

    public override void Die()
    {
        Debug.Log("Player Died");
    }

    public override void Attack(float interval)
    {   
        Debug.Log($"Enemy attacking with a {interval} interval");
    }

    public void SetEnemyType(EnemyType _enemyType)
    {
        enemyType = _enemyType;
    }

    public override void Move(Vector2 direction, Vector2 target)
    {

    }
    public override void Move(float speed)
    {
        transform.Translate(Vector2.right * speed * Time.deltaTime);
    }

    public override void Move(Vector2 direction)
    {
        direction.x -= transform.position.x;
        direction.y -= transform.position.y;

        float angle = Mathf.Atan2( direction.y, direction.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0, 0, angle);

        transform.Translate(Vector2.right * speed * Time.deltaTime)
;    }
    public override void GetDamage(float damage)
    {

    }
}
