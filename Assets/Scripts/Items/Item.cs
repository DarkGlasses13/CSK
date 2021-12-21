using System;
using UnityEngine;

namespace Assets.Scripts
{
    abstract class Item : ScriptableObject, IComparable
    {
        [SerializeField] protected int _id;
        [SerializeField] protected string _title;
        [SerializeField] protected Sprite _looterSprite;

        public Sprite LooterSprite => _looterSprite;

        protected ItemType _type;

        public ItemType Type => _type;
        public int ID => _id;
        public string Title => _title;

        public int CompareTo(object obj)
        {
            Item item = obj as Item;

            if (item != null)
            {
                return _id.CompareTo(item.ID);
            }

            throw new Exception("Не удалось отсортировать");
        }
    }

    public enum ItemType
    {
        Weapon,
        Bandage,
        Money
    }
}
