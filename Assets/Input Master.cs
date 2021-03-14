// GENERATED AUTOMATICALLY FROM 'Assets/Input Master.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @InputMaster : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @InputMaster()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Input Master"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""59140de0-b657-40ab-9f45-fd2f83051d12"",
            ""actions"": [
                {
                    ""name"": ""JumpStart"",
                    ""type"": ""Button"",
                    ""id"": ""b9299642-7e0f-439c-bec9-2e0c499aef7e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""JumpEnd"",
                    ""type"": ""Button"",
                    ""id"": ""fe83897b-1d8a-469b-99ce-7c51b140d7c0"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Movement"",
                    ""type"": ""Value"",
                    ""id"": ""e49e781d-dd38-43b4-a69b-9482605bc482"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press(behavior=2)""
                },
                {
                    ""name"": ""Quick Action"",
                    ""type"": ""Button"",
                    ""id"": ""128a04c1-bf62-4f4a-b8bd-ba9c79be3698"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""d63751fb-8222-4ae1-966e-a92a530ad79a"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and mouse"",
                    ""action"": ""JumpStart"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""A-D Keys"",
                    ""id"": ""5720f85b-459d-4f45-a738-d6cda1c254d7"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""bb1d6c2d-7cec-4bb8-902e-595f6cb772da"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and mouse"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""6c0eefde-8d60-410b-8719-6736c3c7fa1e"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and mouse"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Arrow Keys"",
                    ""id"": ""c5c06135-2560-4f3c-938d-1f6144339229"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""d775f4ac-9478-4e45-a12d-b1e6b81895a7"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and mouse"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""73bffe90-0cca-4897-a416-0eff755f9fcb"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and mouse"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""a1684aea-ca39-4eb5-825c-61b4dcd14e8b"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": ""Press(behavior=1)"",
                    ""processors"": """",
                    ""groups"": ""Keyboard and mouse"",
                    ""action"": ""JumpEnd"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""999d0dae-974f-41ff-af1a-340350bd7814"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and mouse"",
                    ""action"": ""Quick Action"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Keyboard and mouse"",
            ""bindingGroup"": ""Keyboard and mouse"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Mouse>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Gamepad"",
            ""bindingGroup"": ""Gamepad"",
            ""devices"": [
                {
                    ""devicePath"": ""<Gamepad>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // Player
        m_Player = asset.FindActionMap("Player", throwIfNotFound: true);
        m_Player_JumpStart = m_Player.FindAction("JumpStart", throwIfNotFound: true);
        m_Player_JumpEnd = m_Player.FindAction("JumpEnd", throwIfNotFound: true);
        m_Player_Movement = m_Player.FindAction("Movement", throwIfNotFound: true);
        m_Player_QuickAction = m_Player.FindAction("Quick Action", throwIfNotFound: true);
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

    // Player
    private readonly InputActionMap m_Player;
    private IPlayerActions m_PlayerActionsCallbackInterface;
    private readonly InputAction m_Player_JumpStart;
    private readonly InputAction m_Player_JumpEnd;
    private readonly InputAction m_Player_Movement;
    private readonly InputAction m_Player_QuickAction;
    public struct PlayerActions
    {
        private @InputMaster m_Wrapper;
        public PlayerActions(@InputMaster wrapper) { m_Wrapper = wrapper; }
        public InputAction @JumpStart => m_Wrapper.m_Player_JumpStart;
        public InputAction @JumpEnd => m_Wrapper.m_Player_JumpEnd;
        public InputAction @Movement => m_Wrapper.m_Player_Movement;
        public InputAction @QuickAction => m_Wrapper.m_Player_QuickAction;
        public InputActionMap Get() { return m_Wrapper.m_Player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterface != null)
            {
                @JumpStart.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnJumpStart;
                @JumpStart.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnJumpStart;
                @JumpStart.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnJumpStart;
                @JumpEnd.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnJumpEnd;
                @JumpEnd.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnJumpEnd;
                @JumpEnd.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnJumpEnd;
                @Movement.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMovement;
                @QuickAction.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnQuickAction;
                @QuickAction.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnQuickAction;
                @QuickAction.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnQuickAction;
            }
            m_Wrapper.m_PlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @JumpStart.started += instance.OnJumpStart;
                @JumpStart.performed += instance.OnJumpStart;
                @JumpStart.canceled += instance.OnJumpStart;
                @JumpEnd.started += instance.OnJumpEnd;
                @JumpEnd.performed += instance.OnJumpEnd;
                @JumpEnd.canceled += instance.OnJumpEnd;
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @QuickAction.started += instance.OnQuickAction;
                @QuickAction.performed += instance.OnQuickAction;
                @QuickAction.canceled += instance.OnQuickAction;
            }
        }
    }
    public PlayerActions @Player => new PlayerActions(this);
    private int m_KeyboardandmouseSchemeIndex = -1;
    public InputControlScheme KeyboardandmouseScheme
    {
        get
        {
            if (m_KeyboardandmouseSchemeIndex == -1) m_KeyboardandmouseSchemeIndex = asset.FindControlSchemeIndex("Keyboard and mouse");
            return asset.controlSchemes[m_KeyboardandmouseSchemeIndex];
        }
    }
    private int m_GamepadSchemeIndex = -1;
    public InputControlScheme GamepadScheme
    {
        get
        {
            if (m_GamepadSchemeIndex == -1) m_GamepadSchemeIndex = asset.FindControlSchemeIndex("Gamepad");
            return asset.controlSchemes[m_GamepadSchemeIndex];
        }
    }
    public interface IPlayerActions
    {
        void OnJumpStart(InputAction.CallbackContext context);
        void OnJumpEnd(InputAction.CallbackContext context);
        void OnMovement(InputAction.CallbackContext context);
        void OnQuickAction(InputAction.CallbackContext context);
    }
}
