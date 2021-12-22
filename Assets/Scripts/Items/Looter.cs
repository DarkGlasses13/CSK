using System.Collections.Generic;
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
                Debug.Log("Looter was destroyed. No item!");
            }
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.TryGetComponent<Inventory>(out Inventory inventory) && inventory.CanAdd(_item))
            {
                inventory.Add(_item);
                Destroy(gameObject);
            }
        }
    }
}
