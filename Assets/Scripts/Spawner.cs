using UnityEngine;

namespace Assets.Scripts
{
    class Spawner : MonoBehaviour
    {
        [SerializeField] private GameObject _prefab;

        private void Awake()
        {
            name = $"Spawner({_prefab.name})";
        }

        public void Spawn(Transform map)
        {
            Instantiate(_prefab, transform.position, Quaternion.identity, map);
        }
    }
}
