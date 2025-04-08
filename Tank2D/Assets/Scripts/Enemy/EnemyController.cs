using UnityEngine;

public class EnemyController : TankController
{
    [SerializeField] private Transform _player;


    private void Update() 
    {
        Vector3 direction = (_player.transform.position - transform.position).normalized;
        Move(direction);
        GunRotate(direction);
        BodyRotate(direction);
        Shoot();
    }


    protected override void Shoot()
    {
        if (timer >= shotCooldown)
        {
            base.Shoot();
        }
        else
            timer += Time.deltaTime;
    }

    public void TakeDamage(int damage)
    {
        health -= damage;
        if(health <= 0)
            Destroy(gameObject);
    }

}
