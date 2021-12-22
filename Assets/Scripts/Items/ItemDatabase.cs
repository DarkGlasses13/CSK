using UnityEngine;
using System.Collections.Generic;

namespace Assets.Scripts
{
    [CreateAssetMenu(fileName = "New Item Database", menuName = "Item Database")]
    class ItemDatabase : ScriptableObject
    {
        [SerializeField] private List<Item> _items = new List<Item>();

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

        public List<Weapon> GetWeapons()
        {
            List<Weapon> weapons = new List<Weapon>();

            foreach (Item item in _items)
            {
                if (item.Type == ItemType.Weapon)
                {
                    weapons.Add(item as Weapon);
                }
            }

            return weapons;
        }
    }
}
