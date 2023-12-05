using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    [SerializeField] private Bullet _bulletPrefab;

    public void OnShoot(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            Instantiate(_bulletPrefab, transform.position, transform.rotation);
        }
    }
}
