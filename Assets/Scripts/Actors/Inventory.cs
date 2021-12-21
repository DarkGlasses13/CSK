using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts
{
    class Inventory : MonoBehaviour
    {
        [SerializeField] private InventoryPreset _preset;
        [SerializeField] private List<Weapon> _weapons = new List<Weapon>();
        [SerializeField] private List<Bandage> _bandages = new List<Bandage>();
        [SerializeField] private int _money;

        private const int _fistsID = 0;

        public int WeaponCount => _weapons.Count;

        private void Awake()
        {
            Set();
        }

        private void Set()
        {
            foreach (Weapon weapon in _preset.Weapons)
            {
                _weapons.Add(weapon);
            }

            foreach (Bandage bandage in _preset.Bandages)
            {
                _bandages.Add(bandage);
            }

            _money = _preset.Money;
        }

        public void Add(Item addableItem)
        {
            switch (addableItem.Type)
            {
                case ItemType.Weapon:
                    _weapons.Add(addableItem as Weapon);
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

        public void DropAll()
        {

        }

        public Weapon GetWeapon(int id)
        {
            return _weapons[id];
        }

        public void UseBandage()
        {

        }
    }
}
