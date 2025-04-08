using UnityEngine;

public class BulletController : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private float _timeLife;
    [SerializeField] private int _damage;
    [SerializeField] private GameObject _smokePre;
    private float _timer;


    private void Update() {
        BulletMove();
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

    private void BulletMove()
    {
        transform.position += transform.up * _speed * Time.deltaTime;
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.GetComponent<EnemyController>() != null)
        {
            EnemyController enemy = other.GetComponent<EnemyController>();
            enemy.TakeDamage(_damage);
        }
        Destroy(gameObject);
        Instantiate(_smokePre, transform.position, Quaternion.identity);

    }
}
