using Core.Pool;
using UnityEngine;

public class TankController : MoveController
{
    [SerializeField] protected Transform tankBody;
    [SerializeField] protected Transform gun;
    [SerializeField] protected Transform gunPoint;
    [SerializeField] protected GameObject bulletPre;
    [SerializeField] protected float shotCooldown;
    [SerializeField] protected int currentHealth;
    [SerializeField] public int maxHealth;



    protected virtual void Shoot()
    {
        SmartPool.Instance.Spawn(bulletPre, gunPoint.transform.position, gunPoint.transform.rotation, new Vector3(3, 3, 3));
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
        currentHealth -= damage;
        if(currentHealth <= 0)
            OnDead();
    }

    protected virtual void OnDead()
    {
        
    }
}
