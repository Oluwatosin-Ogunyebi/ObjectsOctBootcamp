using UnityEngine;

public abstract class PlayableObject : MonoBehaviour, IDamageable
{
    public Health health = new Health();

    public Weapon weapon;

    public abstract void Move(Vector2 direction, Vector2 target);

    public abstract void Shoot();

    public abstract void Die();

    public abstract void Attack(float interval);

    public abstract void GetDamage(float damage);
}
