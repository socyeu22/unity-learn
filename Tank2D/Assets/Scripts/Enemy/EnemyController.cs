using UnityEngine;
using Core.Pool;

public class EnemyController : TankController
{
    private Transform _player;
    private float timer;

    public SpriteRenderer hpRenderrer;
    private float scaleXDefault = 1.4f;
    private float scaleYDefault = 0.15f;

    private void Start() {
        
    }



    
    public void InitData()
    {
        if(_player == null)
        {
            _player = PlayerController.Instance.transform;
        }

        hpRenderrer.size = new Vector2(0.7f, 1f);
    }
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
    protected override void OnDead()
    {
        EventDispatcher.Instance.PostEvent(EventID.EnemyDie);
        SmartPool.Instance.Despawn(gameObject);

    }

}
