using UnityEngine;
using UnityEngine.Events;

namespace Assets.Scripts
{
    [RequireComponent(typeof(Inventory))]
    abstract class WeaponEquiper : MonoBehaviour
    {
        public UnityEvent<Weapon> OnVew;

        [SerializeField] protected Weapon _equippedWeapon;

        protected Inventory _inventory;
        protected int _selectedWeaponIndex;

        public Weapon EquippedWeapon => _equippedWeapon;
        public int SelectedWeaponIndex => _selectedWeaponIndex;

        public void Set(ItemDatabase database, InventoryPreset preset)
        {
            _equippedWeapon = preset.EquippedWeapon;
            _selectedWeaponIndex = _equippedWeapon.InventoryQueue;
        }

        public abstract void Equip();
    }
}
