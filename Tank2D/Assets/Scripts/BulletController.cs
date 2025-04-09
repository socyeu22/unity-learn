using Core.Pool;
using UnityEngine;

public class BulletController : MoveController
{
    [SerializeField] private float _timeLife;
    [SerializeField] private int _damage;
    [SerializeField] private GameObject _smokePre;
    private float _timer;


    private void Update() {
        base.Move(transform.up);
        if(_timer >= _timeLife)
        {
            Destroy(gameObject);
            Instantiate(_smokePre, transform.position, Quaternion.identity);
        }
        else
        {
            _timer += Time.deltaTime;
        }
    }

    private void OnTriggerEnter2D(Collider2D other) {

        EnemyController enemy = other.GetComponent<EnemyController>();
        {
            enemy?.TakeDamage(_damage);
            GameManager.Instance.AddScore();
            EventDispatcher.Instance.PostEvent(EventID.AttackEnemy);
        }

        PlayerController player = other.GetComponent<PlayerController>();
        player?.TakeDamage(_damage);

        SmartPool.Instance.Despawn(gameObject);
        SmartPool.Instance.Spawn(_smokePre, transform.position, Quaternion.identity);

    }
}
