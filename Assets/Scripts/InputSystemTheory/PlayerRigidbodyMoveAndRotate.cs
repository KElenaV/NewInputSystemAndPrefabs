using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(Rigidbody))]
public class PlayerRigidbodyMoveAndRotate : MonoBehaviour
{
    [SerializeField] private float _rotationSpeed;
    [SerializeField] private float _moveSpeed;

    private Rigidbody _rigidbody;
    private float _rotationInput;
    private float _rotationAngle;
    private float _moveInput;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        _rigidbody.velocity = transform.forward * _moveInput * _moveSpeed * Time.fixedDeltaTime;

        _rotationAngle = _rotationInput * _rotationSpeed * Time.deltaTime;
        Quaternion deltaEuler = Quaternion.Euler(0, _rotationAngle, 0);
        _rigidbody.MoveRotation(_rigidbody.rotation * deltaEuler);
    }

    public void OnRotate(InputAction.CallbackContext context)
    {
        _rotationInput = context.ReadValue<float>();
    }

    public void OnMoveForward(InputAction.CallbackContext context)
    {
        _moveInput = context.ReadValue<float>();
    }
}
