using UnityEngine;
using UnityEngine.Events;

namespace Assets.Scripts
{
    [RequireComponent(typeof(Inventory))]
    class ControllableWeaponEquiper : MonoBehaviour
    {
        [SerializeField] private Weapon _equippedWeapon;

        private InputHandler _inputHandler;
        private Inventory _inventory;
        [SerializeField] private int _selectedWeaponID;

        public Weapon EquippedWeapon => _equippedWeapon;

        private void Awake()
        {
            _inputHandler = new InputHandler();
            _inventory = GetComponent<Inventory>();
        }

        private void Update()
        {
            _selectedWeaponID += (int)(_inputHandler.CharacterControls.Scroll.ReadValue<Vector2>().y);
            _selectedWeaponID = Mathf.Clamp(_selectedWeaponID, 0, _inventory.WeaponCount);

        }

        private void OnEnable()
        {
            _inputHandler.Enable();
        }

        private void OnDisable()
        {
            _inputHandler.Disable();
        }
    }
}
