using UnityEngine;

namespace Assets.Scripts
{
    [RequireComponent(typeof(Animator))]
    class Looter : MonoBehaviour
    {
        [SerializeField] private Item _item;

        private SpriteRenderer _spriteRenderer;

        private void Awake()
        {
            _spriteRenderer = GetComponentInChildren<SpriteRenderer>();

            if (_item != null)
            {
                name = $"Looter({_item.Title})";
                _spriteRenderer.sprite = _item.LooterSprite;
            }
            else
            {
                Destroy(gameObject);
            } 
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.TryGetComponent<Inventory>(out Inventory inventory))
            {
                inventory.Add(_item);
            }
        }

        private void OnDestroy()
        {
            Debug.Log("Looter was destroyed. No item!");
        }
    }
}
