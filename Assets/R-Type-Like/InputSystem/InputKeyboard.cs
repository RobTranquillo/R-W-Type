//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.4.4
//     from Assets/R-Type-Like/InputSystem/InputKeyboard.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @InputKeyboard : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @InputKeyboard()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputKeyboard"",
    ""maps"": [
        {
            ""name"": ""ShipControl"",
            ""id"": ""7a178173-81e7-4e80-9c43-34f1cc1fa1d9"",
            ""actions"": [
                {
                    ""name"": ""ShipUp"",
                    ""type"": ""Button"",
                    ""id"": ""d518e9b8-2669-442c-9fdc-c8be17a0288c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""ShipDown"",
                    ""type"": ""Button"",
                    ""id"": ""6f6934bb-3b07-4b96-8079-0ed4f919d08f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""ShipThrottle"",
                    ""type"": ""Button"",
                    ""id"": ""2a0ea823-7f22-4fcf-9ac6-a8409dd37205"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""ShipAccelerate"",
                    ""type"": ""Button"",
                    ""id"": ""4c1d24f2-e2cd-4219-9c67-f092790375f4"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Fire"",
                    ""type"": ""Button"",
                    ""id"": ""04046fe2-abce-43f2-b881-d9f1f9d636ff"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""f1d3b7cb-ed1f-42f7-9776-4ba8b89c5948"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ShipUp"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""90984b7a-b1cb-4007-9c8a-08854e026b2b"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ShipUp"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b5e04b45-9dc0-4d50-8d92-4e924da01593"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ShipDown"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7cad0ce7-a8da-43ab-b22b-78e202d24e7e"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ShipDown"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""efd99154-6a07-4b90-ac91-91f6ec67d605"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ShipThrottle"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e98fdddd-7c8f-45c5-ab33-721a553dc67f"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ShipThrottle"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1ca89a6a-c1c7-4dd9-a3dd-42bb1423ee54"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ShipAccelerate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8ca8c8b5-c772-4f20-85a8-545a79b4eef9"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ShipAccelerate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""574ac711-0db3-4856-9b09-0634d2c319a8"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Fire"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1499ce8a-6cf2-4179-bfd8-f09125a39405"",
                    ""path"": ""<Keyboard>/shift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Fire"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // ShipControl
        m_ShipControl = asset.FindActionMap("ShipControl", throwIfNotFound: true);
        m_ShipControl_ShipUp = m_ShipControl.FindAction("ShipUp", throwIfNotFound: true);
        m_ShipControl_ShipDown = m_ShipControl.FindAction("ShipDown", throwIfNotFound: true);
        m_ShipControl_ShipThrottle = m_ShipControl.FindAction("ShipThrottle", throwIfNotFound: true);
        m_ShipControl_ShipAccelerate = m_ShipControl.FindAction("ShipAccelerate", throwIfNotFound: true);
        m_ShipControl_Fire = m_ShipControl.FindAction("Fire", throwIfNotFound: true);
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
    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }
    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // ShipControl
    private readonly InputActionMap m_ShipControl;
    private IShipControlActions m_ShipControlActionsCallbackInterface;
    private readonly InputAction m_ShipControl_ShipUp;
    private readonly InputAction m_ShipControl_ShipDown;
    private readonly InputAction m_ShipControl_ShipThrottle;
    private readonly InputAction m_ShipControl_ShipAccelerate;
    private readonly InputAction m_ShipControl_Fire;
    public struct ShipControlActions
    {
        private @InputKeyboard m_Wrapper;
        public ShipControlActions(@InputKeyboard wrapper) { m_Wrapper = wrapper; }
        public InputAction @ShipUp => m_Wrapper.m_ShipControl_ShipUp;
        public InputAction @ShipDown => m_Wrapper.m_ShipControl_ShipDown;
        public InputAction @ShipThrottle => m_Wrapper.m_ShipControl_ShipThrottle;
        public InputAction @ShipAccelerate => m_Wrapper.m_ShipControl_ShipAccelerate;
        public InputAction @Fire => m_Wrapper.m_ShipControl_Fire;
        public InputActionMap Get() { return m_Wrapper.m_ShipControl; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(ShipControlActions set) { return set.Get(); }
        public void SetCallbacks(IShipControlActions instance)
        {
            if (m_Wrapper.m_ShipControlActionsCallbackInterface != null)
            {
                @ShipUp.started -= m_Wrapper.m_ShipControlActionsCallbackInterface.OnShipUp;
                @ShipUp.performed -= m_Wrapper.m_ShipControlActionsCallbackInterface.OnShipUp;
                @ShipUp.canceled -= m_Wrapper.m_ShipControlActionsCallbackInterface.OnShipUp;
                @ShipDown.started -= m_Wrapper.m_ShipControlActionsCallbackInterface.OnShipDown;
                @ShipDown.performed -= m_Wrapper.m_ShipControlActionsCallbackInterface.OnShipDown;
                @ShipDown.canceled -= m_Wrapper.m_ShipControlActionsCallbackInterface.OnShipDown;
                @ShipThrottle.started -= m_Wrapper.m_ShipControlActionsCallbackInterface.OnShipThrottle;
                @ShipThrottle.performed -= m_Wrapper.m_ShipControlActionsCallbackInterface.OnShipThrottle;
                @ShipThrottle.canceled -= m_Wrapper.m_ShipControlActionsCallbackInterface.OnShipThrottle;
                @ShipAccelerate.started -= m_Wrapper.m_ShipControlActionsCallbackInterface.OnShipAccelerate;
                @ShipAccelerate.performed -= m_Wrapper.m_ShipControlActionsCallbackInterface.OnShipAccelerate;
                @ShipAccelerate.canceled -= m_Wrapper.m_ShipControlActionsCallbackInterface.OnShipAccelerate;
                @Fire.started -= m_Wrapper.m_ShipControlActionsCallbackInterface.OnFire;
                @Fire.performed -= m_Wrapper.m_ShipControlActionsCallbackInterface.OnFire;
                @Fire.canceled -= m_Wrapper.m_ShipControlActionsCallbackInterface.OnFire;
            }
            m_Wrapper.m_ShipControlActionsCallbackInterface = instance;
            if (instance != null)
            {
                @ShipUp.started += instance.OnShipUp;
                @ShipUp.performed += instance.OnShipUp;
                @ShipUp.canceled += instance.OnShipUp;
                @ShipDown.started += instance.OnShipDown;
                @ShipDown.performed += instance.OnShipDown;
                @ShipDown.canceled += instance.OnShipDown;
                @ShipThrottle.started += instance.OnShipThrottle;
                @ShipThrottle.performed += instance.OnShipThrottle;
                @ShipThrottle.canceled += instance.OnShipThrottle;
                @ShipAccelerate.started += instance.OnShipAccelerate;
                @ShipAccelerate.performed += instance.OnShipAccelerate;
                @ShipAccelerate.canceled += instance.OnShipAccelerate;
                @Fire.started += instance.OnFire;
                @Fire.performed += instance.OnFire;
                @Fire.canceled += instance.OnFire;
            }
        }
    }
    public ShipControlActions @ShipControl => new ShipControlActions(this);
    public interface IShipControlActions
    {
        void OnShipUp(InputAction.CallbackContext context);
        void OnShipDown(InputAction.CallbackContext context);
        void OnShipThrottle(InputAction.CallbackContext context);
        void OnShipAccelerate(InputAction.CallbackContext context);
        void OnFire(InputAction.CallbackContext context);
    }
}
