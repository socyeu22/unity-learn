using UnityEngine;

public class TankController : MoveController
{
    [SerializeField] protected Transform tankBody;
    [SerializeField] protected Transform gun;
    [SerializeField] protected Transform gunPoint;
    [SerializeField] protected GameObject bulletPre;
    [SerializeField] protected float shotCooldown;
    [SerializeField] protected int health;



    protected virtual void Shoot()
    {
        Instantiate(bulletPre, gunPoint.transform.position, gunPoint.transform.rotation);
    }

    protected virtual void GunRotate(Vector3 gunDirection)
    {
        gun.up = gunDirection;
    }

    protected virtual void BodyRotate(Vector3 direction)
    {
        if(direction != Vector3.zero)
            tankBody.transform.up = direction;
    }
    public virtual void TakeDamage(int damage)
    {
        health -= damage;
        if(health <= 0)
            Destroy(gameObject);
    }
}
