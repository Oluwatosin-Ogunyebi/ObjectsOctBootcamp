using UnityEditor.ShaderGraph.Internal;
using UnityEngine;

public class Enemy
{
    private string enemyName;
    private float speed;
    private EnemyType enemyType;
    public Health health = new Health();

    public void Move(Transform target)
    {
        Debug.Log($"Moving towardss the target {target.name}");
    }

    public void Shoot(Vector3 direction, float speed)
    {
        Debug.Log($"Shooting a bullet towards {direction} with a speed of {speed}");
    }

    public void Die()
    {
        Debug.Log("Player Died");
    }

    public void Attack(float interval)
    {
        Debug.Log($"Enemy attacking with a {interval} interval");
    }

    public void SetEnemyType(EnemyType _enemyType)
    {
        enemyType = _enemyType;
    }
}
