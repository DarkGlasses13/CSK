using UnityEngine;

namespace Assets.Scripts
{
    class ControllableWeaponEquiper : WeaponEquiper
    {
        private InputHandler _inputHandler;

        private void Awake()
        {
            _inputHandler = new InputHandler();
            _inventory = GetComponent<Inventory>();
        }

        private void Update()
        {
            int mouseScrollwheel = (int)_inputHandler.CharacterControls.Scroll.ReadValue<float>() / 120;

            if (mouseScrollwheel != 0)
            {
                _selectedWeaponIndex += mouseScrollwheel;
                _selectedWeaponIndex = Mathf.Clamp(_selectedWeaponIndex, 0, _inventory.WeaponCount - 1);
                Equip();
            }
        }

        public override void Equip()
        {
            _equippedWeapon = _inventory.GetWeapon(this);
            OnVew.Invoke(_equippedWeapon);
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
