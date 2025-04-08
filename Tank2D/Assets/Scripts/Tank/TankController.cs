using UnityEngine;

public class TankController : MoveController
{
    [SerializeField] protected Transform tankBody;
    [SerializeField] protected Transform gun;
    [SerializeField] protected Transform gunPoint;
    [SerializeField] protected GameObject bulletPre;
    [SerializeField] protected float shotCooldown;
    [SerializeField] protected int health;
    protected float timer;


    protected virtual void Shoot()
    {
        Instantiate(bulletPre, gunPoint.transform.position, gunPoint.transform.rotation);
        timer = 0;
    }

    protected virtual void GunRotate(Vector3 shotDirection)
    {
        gun.up = shotDirection;

    }

    protected virtual void BodyRotate(Vector3 direction)
    {
        if(direction != Vector3.zero)
            tankBody.transform.up = direction;
    }
}
