using UnityEngine;
using UnityEngine.InputSystem;

public class CamerasHandler : MonoBehaviour
{
    [SerializeField] private Camera[] _cameras;

    private int _currentCamera = 0;
    private int _changeCameraModifier;

    private void Awake()
    {
        FocusOnCamera(_currentCamera);
    }

    public void OnChangeCamera(InputAction.CallbackContext context)
    {
        if (!context.started)
        {
            _changeCameraModifier = (int)context.ReadValue<float>();
            ChangeCamera(_changeCameraModifier);
        }
    }

    private void FocusOnCamera (int cameraIndex)
    {
        if (cameraIndex >= _cameras.Length)
            return;

        for (int i = 0; i < _cameras.Length; i++)
        {
            _cameras[i].gameObject.SetActive(i == cameraIndex);
        }
    }

    private void ChangeCamera(int changeCameraModifier)
    {
        _currentCamera += _changeCameraModifier;

        if (_currentCamera < 0)
            _currentCamera = _cameras.Length - 1;
        if (_currentCamera >= _cameras.Length)
            _currentCamera = 0;

        for (int i = 0; i < _cameras.Length; i++)
        {
            _cameras[i].gameObject.SetActive(i == _currentCamera);
        }
    }
}
