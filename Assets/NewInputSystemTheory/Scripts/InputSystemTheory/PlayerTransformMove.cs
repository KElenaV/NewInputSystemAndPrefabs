using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerTransformMove : MonoBehaviour
{
    [SerializeField] private float _speed = 2f;

    private float _inputDirection;

    private void Update()
    {
        transform.position += Vector3.right * _speed * _inputDirection * Time.deltaTime;
    }

    public void OnHorizontalMove(InputAction.CallbackContext context)
    {
        _inputDirection = context.ReadValue<float>();
    }
}
