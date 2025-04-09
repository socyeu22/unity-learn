using Core.Pool;
using UnityEngine;

public class SmokeController : MonoBehaviour
{
    public void DestroySmoke()
    {
        SmartPool.Instance.Despawn(gameObject);
    }
}
