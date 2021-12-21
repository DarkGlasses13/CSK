using UnityEngine;
using System.Collections.Generic;

namespace Assets.Scripts
{
    [CreateAssetMenu(fileName = "New Item Database", menuName = "Item Database")]
    class ItemDatabase : ScriptableObject
    {
        [SerializeField] private List<Item> _items = new List<Item>();

        public bool TryGetBandage(out Bandage bandage)
        {
            int bandageId = 0;
            if (TryGetItem(bandageId, out Item item))
            {
                bandage = item as Bandage;
                return true;
            }
            bandage = null;
            return false;
        }

        public bool TryGetItem(int id, out Item item)
        {
            foreach (Item i in _items)
            {
                if (i.ID == id)
                {
                    item = i;
                    return true;
                }
                else
                {
                    continue;
                }
            }

            Debug.Log("Fail to find item !");
            item = null;
            return false;
        }
    }
}
