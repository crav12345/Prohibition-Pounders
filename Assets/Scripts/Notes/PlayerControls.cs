// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/Notes/PlayerControls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerControls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerControls"",
    ""maps"": [
        {
            ""name"": ""Gameplay"",
            ""id"": ""3e184eb2-05c3-4140-a6dc-3fe90d095d0e"",
            ""actions"": [
                {
                    ""name"": ""Face Buttons"",
                    ""type"": ""Value"",
                    ""id"": ""0d945e79-f767-4d3c-9cd8-a008ddd3bac5"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Directional Buttons"",
                    ""type"": ""Value"",
                    ""id"": ""2b49330f-2141-404a-90d8-93d8a78c1d54"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Shoulder Buttons"",
                    ""type"": ""Value"",
                    ""id"": ""59af5efb-9824-412a-9edf-64c3b678e142"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Analog Sticks"",
                    ""type"": ""PassThrough"",
                    ""id"": ""bcf232d8-c88f-4cee-a399-1dcf94c4f51a"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""Gamepad - Face"",
                    ""id"": ""cdfa4f2a-a502-4120-9ad4-05f1b99e4f38"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Face Buttons"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""bc4495f0-83b1-4583-bf77-966a484f4f91"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Face Buttons"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""ef387bea-f5df-4fef-b2f9-02ac546b72ca"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Face Buttons"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""2bf89793-7fb7-4b3e-8d83-26d51d291caa"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Face Buttons"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""b106cf63-1c6a-447e-8eec-9145c904d758"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Face Buttons"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Gamepad - Directional"",
                    ""id"": ""a6ac9b25-8b0f-4021-b130-8a10c637f6ff"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Directional Buttons"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""b3963f18-fd1f-4a79-98fb-72eb1d81535f"",
                    ""path"": ""<Gamepad>/dpad/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Directional Buttons"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""1e67936f-a50b-4bd4-8272-ed38d1365e4f"",
                    ""path"": ""<Gamepad>/dpad/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Directional Buttons"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""ca7a82a2-6b55-4e03-b15a-6152b1beb46e"",
                    ""path"": ""<Gamepad>/dpad/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Directional Buttons"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""251daa9a-bdec-4099-9b52-f22223d4444b"",
                    ""path"": ""<Gamepad>/dpad/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Directional Buttons"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""40d5f316-4b01-4817-af06-3e3609d1401c"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Analog Sticks"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5125f265-13c7-4735-b76e-a80b532398a5"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Analog Sticks"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Gamepad - Shoulder & Trigger"",
                    ""id"": ""bf80de8b-753d-48a3-a6bc-824f8a6bc9ad"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Shoulder Buttons"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""2adea9c8-2971-4722-8c12-e62444c52b94"",
                    ""path"": ""<Gamepad>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Shoulder Buttons"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""82308a8d-bb09-4f0d-b78d-aded827f01cc"",
                    ""path"": ""<Gamepad>/leftShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Shoulder Buttons"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""0f3edc50-958d-457e-9f4d-b893b3056226"",
                    ""path"": ""<Gamepad>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Shoulder Buttons"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""a49f555b-9c6f-42e6-8a49-cd94ce9f93f2"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Shoulder Buttons"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Gameplay
        m_Gameplay = asset.FindActionMap("Gameplay", throwIfNotFound: true);
        m_Gameplay_FaceButtons = m_Gameplay.FindAction("Face Buttons", throwIfNotFound: true);
        m_Gameplay_DirectionalButtons = m_Gameplay.FindAction("Directional Buttons", throwIfNotFound: true);
        m_Gameplay_ShoulderButtons = m_Gameplay.FindAction("Shoulder Buttons", throwIfNotFound: true);
        m_Gameplay_AnalogSticks = m_Gameplay.FindAction("Analog Sticks", throwIfNotFound: true);
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

    // Gameplay
    private readonly InputActionMap m_Gameplay;
    private IGameplayActions m_GameplayActionsCallbackInterface;
    private readonly InputAction m_Gameplay_FaceButtons;
    private readonly InputAction m_Gameplay_DirectionalButtons;
    private readonly InputAction m_Gameplay_ShoulderButtons;
    private readonly InputAction m_Gameplay_AnalogSticks;
    public struct GameplayActions
    {
        private @PlayerControls m_Wrapper;
        public GameplayActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @FaceButtons => m_Wrapper.m_Gameplay_FaceButtons;
        public InputAction @DirectionalButtons => m_Wrapper.m_Gameplay_DirectionalButtons;
        public InputAction @ShoulderButtons => m_Wrapper.m_Gameplay_ShoulderButtons;
        public InputAction @AnalogSticks => m_Wrapper.m_Gameplay_AnalogSticks;
        public InputActionMap Get() { return m_Wrapper.m_Gameplay; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GameplayActions set) { return set.Get(); }
        public void SetCallbacks(IGameplayActions instance)
        {
            if (m_Wrapper.m_GameplayActionsCallbackInterface != null)
            {
                @FaceButtons.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnFaceButtons;
                @FaceButtons.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnFaceButtons;
                @FaceButtons.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnFaceButtons;
                @DirectionalButtons.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnDirectionalButtons;
                @DirectionalButtons.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnDirectionalButtons;
                @DirectionalButtons.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnDirectionalButtons;
                @ShoulderButtons.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnShoulderButtons;
                @ShoulderButtons.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnShoulderButtons;
                @ShoulderButtons.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnShoulderButtons;
                @AnalogSticks.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnAnalogSticks;
                @AnalogSticks.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnAnalogSticks;
                @AnalogSticks.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnAnalogSticks;
            }
            m_Wrapper.m_GameplayActionsCallbackInterface = instance;
            if (instance != null)
            {
                @FaceButtons.started += instance.OnFaceButtons;
                @FaceButtons.performed += instance.OnFaceButtons;
                @FaceButtons.canceled += instance.OnFaceButtons;
                @DirectionalButtons.started += instance.OnDirectionalButtons;
                @DirectionalButtons.performed += instance.OnDirectionalButtons;
                @DirectionalButtons.canceled += instance.OnDirectionalButtons;
                @ShoulderButtons.started += instance.OnShoulderButtons;
                @ShoulderButtons.performed += instance.OnShoulderButtons;
                @ShoulderButtons.canceled += instance.OnShoulderButtons;
                @AnalogSticks.started += instance.OnAnalogSticks;
                @AnalogSticks.performed += instance.OnAnalogSticks;
                @AnalogSticks.canceled += instance.OnAnalogSticks;
            }
        }
    }
    public GameplayActions @Gameplay => new GameplayActions(this);
    public interface IGameplayActions
    {
        void OnFaceButtons(InputAction.CallbackContext context);
        void OnDirectionalButtons(InputAction.CallbackContext context);
        void OnShoulderButtons(InputAction.CallbackContext context);
        void OnAnalogSticks(InputAction.CallbackContext context);
    }
}
