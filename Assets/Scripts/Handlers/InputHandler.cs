// GENERATED AUTOMATICALLY FROM 'Assets/PlayerInput.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

namespace Assets.Scripts
{
    public class @InputHandler : IInputActionCollection, IDisposable
    {
        public InputActionAsset asset { get; }
        public @InputHandler()
        {
            asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInput"",
    ""maps"": [
        {
            ""name"": ""CharacterControls"",
            ""id"": ""1b423c16-1c5d-43d7-b389-9c2942c88a70"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""Value"",
                    ""id"": ""fc8058f9-47bb-4d99-88ac-82c354641a7f"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Attack"",
                    ""type"": ""Button"",
                    ""id"": ""8b53c022-21c5-4f8d-900e-c7e41bc29b62"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Interect"",
                    ""type"": ""Button"",
                    ""id"": ""a3376a00-7906-4437-b797-a09505f783b0"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Look"",
                    ""type"": ""Value"",
                    ""id"": ""109868a8-8140-4be0-bc8b-61193876fd2d"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Scroll"",
                    ""type"": ""PassThrough"",
                    ""id"": ""7d474dc0-e192-43e9-9d15-298f531d0148"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WASD"",
                    ""id"": ""1f4afa3c-995c-4968-9911-f94a5f905fd7"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""d2bb4144-91b8-4a11-a8b8-d5578701d20f"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mouse and keyboard"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""686fcfbe-25cf-46ed-bfce-28892368d163"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mouse and keyboard"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""73c4c1c6-f378-49c9-a0f2-d582407b74ca"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mouse and keyboard"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""b26aa861-1665-4099-aef3-833dcd0c7abd"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mouse and keyboard"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""59a6d681-8c4b-4072-bd92-a2444ae6bd1d"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mouse and keyboard"",
                    ""action"": ""Attack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""49ddd5a4-b08d-4bc1-aaf9-dc97c835584c"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mouse and keyboard"",
                    ""action"": ""Interect"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6f738e73-fc17-4736-8c8e-f23e9a73296f"",
                    ""path"": ""<Mouse>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mouse and keyboard"",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d18faf10-32cc-49fd-ad28-a40430a64310"",
                    ""path"": ""<Mouse>/scroll/y"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mouse and keyboard"",
                    ""action"": ""Scroll"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Mouse and keyboard"",
            ""bindingGroup"": ""Mouse and keyboard"",
            ""devices"": [
                {
                    ""devicePath"": ""<Mouse>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
            // CharacterControls
            m_CharacterControls = asset.FindActionMap("CharacterControls", throwIfNotFound: true);
            m_CharacterControls_Movement = m_CharacterControls.FindAction("Movement", throwIfNotFound: true);
            m_CharacterControls_Attack = m_CharacterControls.FindAction("Attack", throwIfNotFound: true);
            m_CharacterControls_Interect = m_CharacterControls.FindAction("Interect", throwIfNotFound: true);
            m_CharacterControls_Look = m_CharacterControls.FindAction("Look", throwIfNotFound: true);
            m_CharacterControls_Scroll = m_CharacterControls.FindAction("Scroll", throwIfNotFound: true);
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

        // CharacterControls
        private readonly InputActionMap m_CharacterControls;
        private ICharacterControlsActions m_CharacterControlsActionsCallbackInterface;
        private readonly InputAction m_CharacterControls_Movement;
        private readonly InputAction m_CharacterControls_Attack;
        private readonly InputAction m_CharacterControls_Interect;
        private readonly InputAction m_CharacterControls_Look;
        private readonly InputAction m_CharacterControls_Scroll;
        public struct CharacterControlsActions
        {
            private @InputHandler m_Wrapper;
            public CharacterControlsActions(@InputHandler wrapper) { m_Wrapper = wrapper; }
            public InputAction @Movement => m_Wrapper.m_CharacterControls_Movement;
            public InputAction @Attack => m_Wrapper.m_CharacterControls_Attack;
            public InputAction @Interect => m_Wrapper.m_CharacterControls_Interect;
            public InputAction @Look => m_Wrapper.m_CharacterControls_Look;
            public InputAction @Scroll => m_Wrapper.m_CharacterControls_Scroll;
            public InputActionMap Get() { return m_Wrapper.m_CharacterControls; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(CharacterControlsActions set) { return set.Get(); }
            public void SetCallbacks(ICharacterControlsActions instance)
            {
                if (m_Wrapper.m_CharacterControlsActionsCallbackInterface != null)
                {
                    @Movement.started -= m_Wrapper.m_CharacterControlsActionsCallbackInterface.OnMovement;
                    @Movement.performed -= m_Wrapper.m_CharacterControlsActionsCallbackInterface.OnMovement;
                    @Movement.canceled -= m_Wrapper.m_CharacterControlsActionsCallbackInterface.OnMovement;
                    @Attack.started -= m_Wrapper.m_CharacterControlsActionsCallbackInterface.OnAttack;
                    @Attack.performed -= m_Wrapper.m_CharacterControlsActionsCallbackInterface.OnAttack;
                    @Attack.canceled -= m_Wrapper.m_CharacterControlsActionsCallbackInterface.OnAttack;
                    @Interect.started -= m_Wrapper.m_CharacterControlsActionsCallbackInterface.OnInterect;
                    @Interect.performed -= m_Wrapper.m_CharacterControlsActionsCallbackInterface.OnInterect;
                    @Interect.canceled -= m_Wrapper.m_CharacterControlsActionsCallbackInterface.OnInterect;
                    @Look.started -= m_Wrapper.m_CharacterControlsActionsCallbackInterface.OnLook;
                    @Look.performed -= m_Wrapper.m_CharacterControlsActionsCallbackInterface.OnLook;
                    @Look.canceled -= m_Wrapper.m_CharacterControlsActionsCallbackInterface.OnLook;
                    @Scroll.started -= m_Wrapper.m_CharacterControlsActionsCallbackInterface.OnScroll;
                    @Scroll.performed -= m_Wrapper.m_CharacterControlsActionsCallbackInterface.OnScroll;
                    @Scroll.canceled -= m_Wrapper.m_CharacterControlsActionsCallbackInterface.OnScroll;
                }
                m_Wrapper.m_CharacterControlsActionsCallbackInterface = instance;
                if (instance != null)
                {
                    @Movement.started += instance.OnMovement;
                    @Movement.performed += instance.OnMovement;
                    @Movement.canceled += instance.OnMovement;
                    @Attack.started += instance.OnAttack;
                    @Attack.performed += instance.OnAttack;
                    @Attack.canceled += instance.OnAttack;
                    @Interect.started += instance.OnInterect;
                    @Interect.performed += instance.OnInterect;
                    @Interect.canceled += instance.OnInterect;
                    @Look.started += instance.OnLook;
                    @Look.performed += instance.OnLook;
                    @Look.canceled += instance.OnLook;
                    @Scroll.started += instance.OnScroll;
                    @Scroll.performed += instance.OnScroll;
                    @Scroll.canceled += instance.OnScroll;
                }
            }
        }
        public CharacterControlsActions @CharacterControls => new CharacterControlsActions(this);
        private int m_MouseandkeyboardSchemeIndex = -1;
        public InputControlScheme MouseandkeyboardScheme
        {
            get
            {
                if (m_MouseandkeyboardSchemeIndex == -1) m_MouseandkeyboardSchemeIndex = asset.FindControlSchemeIndex("Mouse and keyboard");
                return asset.controlSchemes[m_MouseandkeyboardSchemeIndex];
            }
        }
        public interface ICharacterControlsActions
        {
            void OnMovement(InputAction.CallbackContext context);
            void OnAttack(InputAction.CallbackContext context);
            void OnInterect(InputAction.CallbackContext context);
            void OnLook(InputAction.CallbackContext context);
            void OnScroll(InputAction.CallbackContext context);
        }
    }
}
