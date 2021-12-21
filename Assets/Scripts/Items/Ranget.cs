using UnityEngine;

namespace Assets.Scripts
{
    class Ranget : Weapon
    {
        [SerializeField] [Range(10, 100)] protected float _maxDistance;
    }
}
