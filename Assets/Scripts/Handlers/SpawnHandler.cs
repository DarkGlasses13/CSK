using UnityEngine;
using System.Collections.Generic;
using UnityEngine.Events;

namespace Assets.Scripts
{
    class SpawnHandler : MonoBehaviour
    {
        public UnityEvent<Transform> OnSpawn;

        [SerializeField] private Transform _map;

        private void Start()
        {
            OnSpawn.Invoke(_map);
        }
    }
}
