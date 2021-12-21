using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts
{
    [CreateAssetMenu(fileName = "New Inventory Set", menuName = "Inventory Set")]

    class InventoryPreset : ScriptableObject
    {
        [SerializeField] private ItemDatabase _database;
        [SerializeField] private int _money;
        [SerializeField] private List<Weapon> _weaponPocket = new List<Weapon>();
        [SerializeField] private List<Bandage> _bandagePocket = new List<Bandage>();

        public int Money => _money;
        public List<Weapon> Weapons => _weaponPocket;
        public List<Bandage> Bandages => _bandagePocket;
    }
}
