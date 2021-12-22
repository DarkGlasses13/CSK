using UnityEngine;

namespace Assets.Scripts
{
    class WeaponVew : MonoBehaviour
    {
        [SerializeField] private Weapon _weapon;

        public Weapon Weapon => _weapon;
    }
}
