using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private float _moveSpeed;
    [SerializeField] private int _health;
    [SerializeField] private Transform _player;
    [SerializeField] private GameObject _bulletPre;
    [SerializeField] private Transform _gunPoint;
    [SerializeField] private Transform _gun;
    [SerializeField] private float _shotCooldown = 50f;
    private float _timer;
    private void Start() {
        
    }

    private void Update() {
        transform.position = Vector3.MoveTowards(transform.position, _player.position, _moveSpeed * Time.deltaTime);
        Shoot();
    }

    private void Shoot()
    {
        Vector3 shotDirection = (_player.position - transform.position).normalized;
        _gun.up = shotDirection;

        if(_timer >= _shotCooldown)
        {
            GameObject newBullet = Instantiate(_bulletPre, _gunPoint.transform.position, _gunPoint.transform.rotation);
            _timer = 0;

        }
        else
            _timer += Time.deltaTime;
    }

    public void TakeDamage(int damage)
    {
        _health -= damage;
        if(_health <= 0)
            Destroy(gameObject);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(collision.gameObject);
        Debug.Log("Va cham enemy ");
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Va cham enemy");
    }
}
