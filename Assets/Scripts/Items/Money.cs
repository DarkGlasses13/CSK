using UnityEngine;

namespace Assets.Scripts
{
    [CreateAssetMenu(fileName = "New Monew Wad", menuName = "Monew Wad")]
    class Money : Item
    {
        [SerializeField] private int _amount;

        public int Amount => _amount;

        public void Awake()
        {
            _type = ItemType.Money;
        }

    }
}
