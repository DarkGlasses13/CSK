using System;
using UnityEngine;

namespace Assets.Scripts
{
    abstract class Weapon : Item, IComparable
    {
        [SerializeField] protected WeaponType _weaponType;
        [SerializeField] [Range(1, 1000)] protected float _damage;
        [SerializeField] protected Sprite _icon;
        [SerializeField] protected GameObject _vew;
        [SerializeField] protected int _inventoryQueue;

        public WeaponType WeaponType => _weaponType;
        public float Damage => _damage;
        public Sprite Icon => _icon;
        public GameObject Vew => _vew;
        public int InventoryQueue => _inventoryQueue;

        private void Awake()
        {
            _type = ItemType.Weapon;
        }

        public int CompareTo(object item)
        {
            Weapon weapon = item as Weapon;

            if (weapon != null)
            {
                return _inventoryQueue.CompareTo(weapon.InventoryQueue);
            }

            throw new Exception("Не удалось отсортировать");
        }
    }

    public enum WeaponType
    {
        Fists,
        OneHandedMelee,
        DoublehandedMelee,
        OnehandedFirearm,
        DoublehandedFirearm
    }
}
