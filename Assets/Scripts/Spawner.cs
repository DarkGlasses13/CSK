using UnityEngine;
using UnityEngine.Events;

namespace Assets.Scripts
{
    class Spawner : MonoBehaviour
    {
        public UnityEvent OnSpawn;

        [SerializeField] private GameObject _prefab;

        private void Awake()
        {
            name = $"Spawner({_prefab.name})";
        }

        private void Start()
        {
            OnSpawn.Invoke();
        }

        public void Spawn(Transform map)
        {
            Instantiate(_prefab, transform.position, Quaternion.identity, map);
        }
    }
}
