using UnityEngine;

public class TankMoveMent : MonoBehaviour
{
    [SerializeField] private float _speed = 5f;
    [SerializeField] private Transform _tankBody;
    [SerializeField] private Transform _gun;
    [SerializeField] private Transform _gunPoint;
    [SerializeField] private GameObject _bulletPre;

    private void Start() {
    }

    private void Update()
    {
        Move();
        Shoot();
    }

    private void Move()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveY = Input.GetAxis("Vertical");
        Vector3 direction = new Vector3(moveX, moveY, 0);
        if (direction != Vector3.zero)
            _tankBody.transform.up = direction;

        _tankBody.position += direction * _speed * Time.deltaTime;
    }

    private void Shoot()
    {
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePosition.z = 0;
        Vector3 gunDirection = (mousePosition - transform.position).normalized;
 
        _gun.up = gunDirection;

        
        if(Input.GetMouseButtonDown(0))
        {

            GameObject newBullet = Instantiate(_bulletPre, _gunPoint.transform.position, _gunPoint.transform.rotation);
        
        }
    }

}
