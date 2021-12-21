using UnityEngine;

namespace Assets.Scripts
{
    [CreateAssetMenu(fileName = "New Bandage", menuName = "Bandage")]
    class Bandage : Item
    {
        [SerializeField] [Range(1, 100)] private float _restoreValue;

        private void Awake()
        {
            _type = ItemType.Bandage;
        }
    }
}
