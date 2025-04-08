using UnityEngine;

public class MoveController : MonoBehaviour
{
    [SerializeField] protected float moveSpeed;
    protected virtual void Move(Vector3 direction)
    {
        transform.position += direction * moveSpeed * Time.deltaTime;
    }
}
