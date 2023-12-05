// GENERATED AUTOMATICALLY FROM 'Assets/NewInputSystemTheory/InputSystem/InputActions.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @InputActions : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @InputActions()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputActions"",
    ""maps"": [
        {
            ""name"": ""Controller"",
            ""id"": ""4f9ad61d-4280-454f-9161-73565354d10d"",
            ""actions"": [
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""4bbefd7f-757e-4691-87c4-f63d7f7dfa15"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MoveLeft"",
                    ""type"": ""Button"",
                    ""id"": ""be6b98fb-5000-4752-83db-2dac78339f6a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MoveRight"",
                    ""type"": ""Button"",
                    ""id"": ""f74a9606-e7ff-4e05-8a2b-f221e89f8e05"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""c01b1623-cb04-4a17-8b65-61a12858be03"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""77383179-cdb0-4249-8965-58a4eb5a15f1"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f119bbc3-3de7-4d7b-9129-f24705e8af92"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Player"",
            ""id"": ""3c4d5c0b-45ce-463d-b72b-764021630192"",
            ""actions"": [
                {
                    ""name"": ""HorizontalMove"",
                    ""type"": ""Value"",
                    ""id"": ""40f32064-8150-48cb-9d70-25c45434db43"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""b45c8352-1738-4248-9301-7bd414c759de"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""0403bc52-e7a6-4930-a761-c1dcf601d790"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""HorizontalMove"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""4f032878-04ed-45fe-8e91-bc4f016f1814"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""HorizontalMove"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""0eb5a17e-cd63-4a69-ab29-09c4064d1562"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""HorizontalMove"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""659fa1dc-de10-4d6f-afa1-cc2e7649bcb0"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""RotatingPlayer"",
            ""id"": ""91f48aa7-5daa-49ac-bfb2-c025e9b30504"",
            ""actions"": [
                {
                    ""name"": ""Rotate"",
                    ""type"": ""Value"",
                    ""id"": ""0f08b35c-ae75-4d85-86b6-b69510d1855b"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MoveForvard"",
                    ""type"": ""Button"",
                    ""id"": ""db40701b-8cfb-4683-8921-bad30142a9ac"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""5ce3e903-3b70-489c-9cc7-792e3663ff02"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotate"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""863137ec-f9b3-4d64-8429-ef4626799d75"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""964f7441-9e9f-4a53-86dd-c19865fa6b46"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""07575e8c-d57f-4b58-9b01-8c0cb20771d6"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveForvard"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""CameraChanger"",
            ""id"": ""449fa0e3-a361-4b5c-9bac-65e58f1e75fa"",
            ""actions"": [
                {
                    ""name"": ""ChangeCamera"",
                    ""type"": ""Value"",
                    ""id"": ""bcf70c60-2627-4449-8af8-ea37c6bc4c48"",
                    ""expectedControlType"": ""Integer"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""60dc8dd1-50c1-4d8d-825f-b31ab0998e4c"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ChangeCamera"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""190e618a-23ac-4a5d-9249-69aaa1ca31b4"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ChangeCamera"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""84a898c5-5cd8-4615-b19f-cc7ddfadcaa1"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ChangeCamera"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Controller
        m_Controller = asset.FindActionMap("Controller", throwIfNotFound: true);
        m_Controller_Jump = m_Controller.FindAction("Jump", throwIfNotFound: true);
        m_Controller_MoveLeft = m_Controller.FindAction("MoveLeft", throwIfNotFound: true);
        m_Controller_MoveRight = m_Controller.FindAction("MoveRight", throwIfNotFound: true);
        // Player
        m_Player = asset.FindActionMap("Player", throwIfNotFound: true);
        m_Player_HorizontalMove = m_Player.FindAction("HorizontalMove", throwIfNotFound: true);
        m_Player_Jump = m_Player.FindAction("Jump", throwIfNotFound: true);
        // RotatingPlayer
        m_RotatingPlayer = asset.FindActionMap("RotatingPlayer", throwIfNotFound: true);
        m_RotatingPlayer_Rotate = m_RotatingPlayer.FindAction("Rotate", throwIfNotFound: true);
        m_RotatingPlayer_MoveForvard = m_RotatingPlayer.FindAction("MoveForvard", throwIfNotFound: true);
        // CameraChanger
        m_CameraChanger = asset.FindActionMap("CameraChanger", throwIfNotFound: true);
        m_CameraChanger_ChangeCamera = m_CameraChanger.FindAction("ChangeCamera", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }

    // Controller
    private readonly InputActionMap m_Controller;
    private IControllerActions m_ControllerActionsCallbackInterface;
    private readonly InputAction m_Controller_Jump;
    private readonly InputAction m_Controller_MoveLeft;
    private readonly InputAction m_Controller_MoveRight;
    public struct ControllerActions
    {
        private @InputActions m_Wrapper;
        public ControllerActions(@InputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Jump => m_Wrapper.m_Controller_Jump;
        public InputAction @MoveLeft => m_Wrapper.m_Controller_MoveLeft;
        public InputAction @MoveRight => m_Wrapper.m_Controller_MoveRight;
        public InputActionMap Get() { return m_Wrapper.m_Controller; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(ControllerActions set) { return set.Get(); }
        public void SetCallbacks(IControllerActions instance)
        {
            if (m_Wrapper.m_ControllerActionsCallbackInterface != null)
            {
                @Jump.started -= m_Wrapper.m_ControllerActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_ControllerActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_ControllerActionsCallbackInterface.OnJump;
                @MoveLeft.started -= m_Wrapper.m_ControllerActionsCallbackInterface.OnMoveLeft;
                @MoveLeft.performed -= m_Wrapper.m_ControllerActionsCallbackInterface.OnMoveLeft;
                @MoveLeft.canceled -= m_Wrapper.m_ControllerActionsCallbackInterface.OnMoveLeft;
                @MoveRight.started -= m_Wrapper.m_ControllerActionsCallbackInterface.OnMoveRight;
                @MoveRight.performed -= m_Wrapper.m_ControllerActionsCallbackInterface.OnMoveRight;
                @MoveRight.canceled -= m_Wrapper.m_ControllerActionsCallbackInterface.OnMoveRight;
            }
            m_Wrapper.m_ControllerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @MoveLeft.started += instance.OnMoveLeft;
                @MoveLeft.performed += instance.OnMoveLeft;
                @MoveLeft.canceled += instance.OnMoveLeft;
                @MoveRight.started += instance.OnMoveRight;
                @MoveRight.performed += instance.OnMoveRight;
                @MoveRight.canceled += instance.OnMoveRight;
            }
        }
    }
    public ControllerActions @Controller => new ControllerActions(this);

    // Player
    private readonly InputActionMap m_Player;
    private IPlayerActions m_PlayerActionsCallbackInterface;
    private readonly InputAction m_Player_HorizontalMove;
    private readonly InputAction m_Player_Jump;
    public struct PlayerActions
    {
        private @InputActions m_Wrapper;
        public PlayerActions(@InputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @HorizontalMove => m_Wrapper.m_Player_HorizontalMove;
        public InputAction @Jump => m_Wrapper.m_Player_Jump;
        public InputActionMap Get() { return m_Wrapper.m_Player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterface != null)
            {
                @HorizontalMove.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnHorizontalMove;
                @HorizontalMove.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnHorizontalMove;
                @HorizontalMove.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnHorizontalMove;
                @Jump.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnJump;
            }
            m_Wrapper.m_PlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @HorizontalMove.started += instance.OnHorizontalMove;
                @HorizontalMove.performed += instance.OnHorizontalMove;
                @HorizontalMove.canceled += instance.OnHorizontalMove;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
            }
        }
    }
    public PlayerActions @Player => new PlayerActions(this);

    // RotatingPlayer
    private readonly InputActionMap m_RotatingPlayer;
    private IRotatingPlayerActions m_RotatingPlayerActionsCallbackInterface;
    private readonly InputAction m_RotatingPlayer_Rotate;
    private readonly InputAction m_RotatingPlayer_MoveForvard;
    public struct RotatingPlayerActions
    {
        private @InputActions m_Wrapper;
        public RotatingPlayerActions(@InputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Rotate => m_Wrapper.m_RotatingPlayer_Rotate;
        public InputAction @MoveForvard => m_Wrapper.m_RotatingPlayer_MoveForvard;
        public InputActionMap Get() { return m_Wrapper.m_RotatingPlayer; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(RotatingPlayerActions set) { return set.Get(); }
        public void SetCallbacks(IRotatingPlayerActions instance)
        {
            if (m_Wrapper.m_RotatingPlayerActionsCallbackInterface != null)
            {
                @Rotate.started -= m_Wrapper.m_RotatingPlayerActionsCallbackInterface.OnRotate;
                @Rotate.performed -= m_Wrapper.m_RotatingPlayerActionsCallbackInterface.OnRotate;
                @Rotate.canceled -= m_Wrapper.m_RotatingPlayerActionsCallbackInterface.OnRotate;
                @MoveForvard.started -= m_Wrapper.m_RotatingPlayerActionsCallbackInterface.OnMoveForvard;
                @MoveForvard.performed -= m_Wrapper.m_RotatingPlayerActionsCallbackInterface.OnMoveForvard;
                @MoveForvard.canceled -= m_Wrapper.m_RotatingPlayerActionsCallbackInterface.OnMoveForvard;
            }
            m_Wrapper.m_RotatingPlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Rotate.started += instance.OnRotate;
                @Rotate.performed += instance.OnRotate;
                @Rotate.canceled += instance.OnRotate;
                @MoveForvard.started += instance.OnMoveForvard;
                @MoveForvard.performed += instance.OnMoveForvard;
                @MoveForvard.canceled += instance.OnMoveForvard;
            }
        }
    }
    public RotatingPlayerActions @RotatingPlayer => new RotatingPlayerActions(this);

    // CameraChanger
    private readonly InputActionMap m_CameraChanger;
    private ICameraChangerActions m_CameraChangerActionsCallbackInterface;
    private readonly InputAction m_CameraChanger_ChangeCamera;
    public struct CameraChangerActions
    {
        private @InputActions m_Wrapper;
        public CameraChangerActions(@InputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @ChangeCamera => m_Wrapper.m_CameraChanger_ChangeCamera;
        public InputActionMap Get() { return m_Wrapper.m_CameraChanger; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(CameraChangerActions set) { return set.Get(); }
        public void SetCallbacks(ICameraChangerActions instance)
        {
            if (m_Wrapper.m_CameraChangerActionsCallbackInterface != null)
            {
                @ChangeCamera.started -= m_Wrapper.m_CameraChangerActionsCallbackInterface.OnChangeCamera;
                @ChangeCamera.performed -= m_Wrapper.m_CameraChangerActionsCallbackInterface.OnChangeCamera;
                @ChangeCamera.canceled -= m_Wrapper.m_CameraChangerActionsCallbackInterface.OnChangeCamera;
            }
            m_Wrapper.m_CameraChangerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @ChangeCamera.started += instance.OnChangeCamera;
                @ChangeCamera.performed += instance.OnChangeCamera;
                @ChangeCamera.canceled += instance.OnChangeCamera;
            }
        }
    }
    public CameraChangerActions @CameraChanger => new CameraChangerActions(this);
    public interface IControllerActions
    {
        void OnJump(InputAction.CallbackContext context);
        void OnMoveLeft(InputAction.CallbackContext context);
        void OnMoveRight(InputAction.CallbackContext context);
    }
    public interface IPlayerActions
    {
        void OnHorizontalMove(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
    }
    public interface IRotatingPlayerActions
    {
        void OnRotate(InputAction.CallbackContext context);
        void OnMoveForvard(InputAction.CallbackContext context);
    }
    public interface ICameraChangerActions
    {
        void OnChangeCamera(InputAction.CallbackContext context);
    }
}
