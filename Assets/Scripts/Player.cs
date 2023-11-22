using UnityEngine;

public class Player: PlayableObject
{
    private string nickName;
    [SerializeField] private Camera cam;
    [SerializeField] private float speed;

    private Rigidbody2D playerRB;

    public override void Shoot(Vector3 direction, float speed)
    {
        Debug.Log($"Shooting a bullet towards {direction} with a speed of {speed}");
    }

    public override void Die()
    {

    }

    public override void Move(Vector2 direction, Vector2 target)
    {
        playerRB.velocity = direction * speed * Time.deltaTime;
        var playerScreenPos = cam.WorldToScreenPoint(transform.position);

        //TODO: Target and Rotation
    }

    public override void Attack(float interval)
    {

    }

    public override void GetDamage(float damage)
    {

    }
}
