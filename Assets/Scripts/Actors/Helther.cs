using UnityEngine;
using UnityEngine.Events;

namespace Assets.Scripts
{
    class Helther : MonoBehaviour
    {
        [SerializeField] [Range(0, 1000)] float _maxHelth;

        public float MaxHelth => _maxHelth;
        public float Helth { get; private set; }

        private void Awake()
        {
            Helth = _maxHelth;
        }

        private void TakeDamage()
        {

        }

        private void Restore()
        {

        }
    }
}
