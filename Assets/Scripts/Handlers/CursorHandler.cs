using UnityEngine;

namespace Assets.Scripts
{
    [RequireComponent(typeof(RectTransform))]
    class CursorHandler : MonoBehaviour
    {
        [SerializeField] private Texture2D _defaultCursor;
        [SerializeField] private Texture2D _crosshair;

        public CursorType Type { get; private set; }

        private void Start()
        {
            SetCursor(_crosshair, Vector2.zero);
        }

        private void SetCursor(Texture2D texture, Vector2 offset)
        {
            Cursor.SetCursor(texture, offset, CursorMode.Auto);
        }
    }

    public enum CursorType
    {
        Default,
        Crosshair
    }
}
