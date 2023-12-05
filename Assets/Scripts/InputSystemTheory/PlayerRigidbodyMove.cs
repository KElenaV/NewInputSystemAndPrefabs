using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(Rigidbody))]
public class PlayerRigidbodyMove : MonoBehaviour
{
    [SerializeField] private float _speed = 8;
    [SerializeField] private float _jumpingPower = 5f;
    
    private Rigidbody _rigidbody;
    private float _horizontal;
    private bool _isGrounded = false;
    private bool _needToStop = false;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if (_needToStop && _isGrounded)
        {
            _horizontal = 0;
            _needToStop = false;
        }
        else
        {
            _rigidbody.velocity = new Vector3(_horizontal * _speed, _rigidbody.velocity.y, _rigidbody.velocity.z);
        }
    }

    public void OnHorizontalMove(InputAction.CallbackContext context)
    {
        if (!_isGrounded)
            if (context.canceled)
                _needToStop = true;

        if (_isGrounded)
            _horizontal = context.ReadValue<float>();
    }

    public void OnJump(InputAction.CallbackContext context)
    {
        if (context.performed && _isGrounded)
        {
            _rigidbody.AddForce(Vector3.up * _jumpingPower, ForceMode.Impulse);
            _isGrounded = false;
        }

        //if (context.canceled && Mathf.Abs(_rigidbody.velocity.y) > 0f)
        //{
        //    _rigidbody.velocity = new Vector3(_rigidbody.velocity.x, _rigidbody.velocity.y * 0.5f, _rigidbody.velocity.z);
        //}
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.TryGetComponent(out Ground ground))
            _isGrounded = true;
    }
}


