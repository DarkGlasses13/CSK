using UnityEngine;
using UnityEngine.Events;

namespace Assets.Scripts
{
    class InventorySetter : MonoBehaviour
    {
        public UnityEvent<ItemDatabase, InventoryPreset> OnSet;

        [SerializeField] private ItemDatabase _database;
        [SerializeField] private InventoryPreset _preset;

        private void OnEnable()
        {
            OnSet.Invoke(_database, _preset);
        }
    }
}
