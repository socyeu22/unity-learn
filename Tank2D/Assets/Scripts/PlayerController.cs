using UnityEngine;

public class PlayerController : TankController
{
    private void Update()
    {
        Vector3 direction = InputHandle();
        BodyRotate(direction);
        Move(direction);
        Shoot();

        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePosition.z = 0;
        Vector3 gunDirection = (mousePosition - transform.position).normalized;
 
        GunRotate(gunDirection);
    }

    private Vector3 InputHandle()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveY = Input.GetAxis("Vertical");
        Vector3 direction = new Vector3(moveX, moveY, 0);
        return direction;
    }

    protected override void Shoot()
    {
        if(Input.GetMouseButtonDown(0) && timer >= shotCooldown)
        {
            base.Shoot();
        }
        timer += Time.deltaTime;
    }

}
