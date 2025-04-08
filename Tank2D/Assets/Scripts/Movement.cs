using UnityEngine;

public class Movement : MonoBehaviour
{
    private float speed = 5f;
    private Vector3[] squearePath = new Vector3[4];
    private Transform target;
    Vector3 axis = Vector3.forward; // Trục Z
    float angle = 30f;
    Quaternion rotation;

    private void Start() {
        transform.position = new Vector3(0, 0, 0);
        squearePath[0] = new Vector3(0, 0, 0);
        squearePath[1] = new Vector3(0, 4, 0);
        squearePath[2] = new Vector3(4, 4, 0);
        squearePath[3] = new Vector3(4, 0, 0);
        rotation = Quaternion.AngleAxis(angle * Time.deltaTime, axis);
    }
    void Update()
    {

        // if(transform.position.x <= 2 && transform.position.y >= -0.1)
        // {
        //     transform.position += Vector3.right * Time.deltaTime * speed;
        // }
        // else if(transform.position.x >= 2 && transform.position.y >= -2)
        // {
        //     transform.position += Vector3.down * Time.deltaTime * speed;
        // }
        // else if (transform.position.x >= 0 && transform.position.y <= -2)
        // {
        //     transform.position += Vector3.left * Time.deltaTime * speed;
        // }
        // else if (transform.position.x <= 2 && transform.position.y <=0)
        // {
        //     transform.position += Vector3.up * Time.deltaTime * speed;
        // }
        // Có những loại di chuyển nào và khác nhau như nào

        // transform.Rotate(new Vector3(0, 0, 22) * Time.deltaTime * speed);
        // transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, transform.rotation.z + 22 * Time.deltaTime * speed);
        // transform.rotation *= rotation;
    }
}
