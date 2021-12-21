using UnityEngine;

namespace Assets.Scripts
{
    abstract class Weapon : Item
    {
        [SerializeField] protected WeaponType _weaponType;
        [SerializeField] [Range(1, 1000)] protected float _damage;
        [SerializeField] protected Sprite _icon;
        [SerializeField] protected GameObject _vew;

        public WeaponType WeaponType => _weaponType;
        public float Damage => _damage;
        public Sprite Icon => _icon;
        public GameObject Vew => _vew;

        private void Awake()
        {
            _type = ItemType.Weapon;
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
