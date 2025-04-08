using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private Transform _followTransform;
    [SerializeField] private float _cameraDistance = -10f;
    [SerializeField] private float _speed = 20f;

    void Update()
    {
        FollowPlayer();
    }

    private void FollowPlayer()
    {
        if(_followTransform != null)
        {
            Vector3 targetCameraPositon = new Vector3(_followTransform.position.x, _followTransform.position.y, _cameraDistance);
            transform.position = Vector3.Lerp(transform.position, targetCameraPositon, _speed * Time.deltaTime);
        }
    }
}
