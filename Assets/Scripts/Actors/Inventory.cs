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

        private void Awake()
        {
            Set();
        }

        private void Set()
        {
            _weapons = _preset.Weapons;
            _bandages = _preset.Bandages;
            _money = _preset.Money;
        }

        public void Add(Item addableItem)
        {
            switch (addableItem.Type)
            {
                case ItemType.Weapon:
                    _weapons.Add(addableItem as Weapon);
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

        public void UseBandage()
        {

        }
    }
}
