using UnityEngine;
using UnityEngine.InputSystem;

public class InputController : MonoBehaviour
{
    private bool _isMovingLeft = false;
    private bool _isMovingRight = false;

    private void Update()
    {
        if (_isMovingLeft)
            Debug.Log("Move left");
        if (_isMovingRight)
            Debug.Log("Move right");
    }

    public void OnJump(InputAction.CallbackContext context)
    {
        if(context.performed)
            Debug.Log("Jump");
    }

    public void OnMoveLeft(InputAction.CallbackContext context)
    {
        _isMovingLeft = !context.canceled;
    }

    public void OnMoveRight(InputAction.CallbackContext context)
    {
        _isMovingRight = !context.canceled;
    }
}
