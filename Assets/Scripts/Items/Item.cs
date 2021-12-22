using System;
using UnityEngine;

namespace Assets.Scripts
{
    abstract class Item : ScriptableObject
    {
        [SerializeField] protected int _id;
        [SerializeField] protected string _title;
        [SerializeField] protected Sprite _looterSprite;

        public Sprite LooterSprite => _looterSprite;

        protected ItemType _type;

        public ItemType Type => _type;
        public int ID => _id;
        public string Title => _title;
    }

    public enum ItemType
    {
        Weapon,
        Bandage,
        Money
    }
}
