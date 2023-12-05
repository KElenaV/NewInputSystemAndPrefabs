using UnityEngine;

public class ChaseCamera : MonoBehaviour
{
    [SerializeField] private Transform _target;

    private void Update()
    {
        transform.LookAt(_target);
    }
}
