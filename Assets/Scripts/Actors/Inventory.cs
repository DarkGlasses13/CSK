using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts
{
    [RequireComponent(typeof(InventorySetter))]
    class Inventory : MonoBehaviour
    {
        [SerializeField] private List<Weapon> _weapons = new List<Weapon>();
        [SerializeField] private List<Bandage> _bandages = new List<Bandage>();
        [SerializeField] private int _money;

        public int WeaponCount => _weapons.Count;

        public void Set(InventoryPreset preset)
        {
            foreach (Weapon weapon in preset.Weapons)
            {
                Add(weapon);
            }

            foreach (Bandage bandage in preset.Bandages)
            {
                Add(bandage);
            }

            _money = preset.Money;
        }

        public void Add(Item addableItem)
        {
            switch (addableItem.Type)
            {
                case ItemType.Weapon:
                    Weapon addableWeapon = addableItem as Weapon;
                    _weapons.Add(addableWeapon);
                    _weapons.Sort();
                    break;

                case ItemType.Bandage:
                    _bandages.Add(addableItem as Bandage);
                    break;

                case ItemType.Money:
                    Money addableMoney = addableItem as Money;
                    _money += addableMoney.Amount;
                    break;
            }
        }

        public bool CanAdd(Item addableItem)
        {
            if (addableItem.Type == ItemType.Weapon)
            {
                foreach (Weapon weapon in _weapons)
                {
                    if (weapon.ID == addableItem.ID) { return false; }
                }

                return true;
            }

            return true;
        }

        public void DropAll()
        {

        }

        public Weapon GetWeapon(WeaponEquiper equiper)
        {
            return _weapons[equiper.SelectedWeaponIndex];
        }

        public void UseBandage()
        {

        }
    }
}
