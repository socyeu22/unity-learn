using UnityEngine;

public class EnemyController : TankController
{
    [SerializeField] private Transform _player;
    private float timer;

    private void Update() 
    {
        if(_player != null)
        {
            Vector3 direction = (_player.transform.position - transform.position).normalized;
            Move(direction);
            GunRotate(direction);
            BodyRotate(direction);
            Shoot();
        }
    }


    protected override void Shoot()
    {
        if (timer >= shotCooldown)
        {
            base.Shoot();
            timer = 0;
        }
        else
            timer += Time.deltaTime;
    }

}
