using UnityEngine;

public class Bullet
{
    private float damage;

    private void Move(Transform target)
    {
        Debug.Log($"Bullet moving towards {target.name} to do a damage of {damage}");
    }

    private void Damage()
    {
        Debug.Log($"Damaged Something");
    }
}
