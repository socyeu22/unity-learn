using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private Transform _followTransform;
    [SerializeField] private float _cameraDistance = -10f;
    [SerializeField] private float _speed = 20f;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(_followTransform.position.x, _followTransform.position.y, _cameraDistance);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 targetCameraPositon = new Vector3(_followTransform.position.x, _followTransform.position.y, _cameraDistance);
        transform.position = Vector3.Lerp(transform.position, targetCameraPositon, _speed * Time.deltaTime);
    }
}
