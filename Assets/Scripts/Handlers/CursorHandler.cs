using UnityEngine;

namespace Assets.Scripts
{
    [RequireComponent(typeof(RectTransform))]
    class CursorHandler : MonoBehaviour
    {
        [SerializeField] private Texture2D _defaultCursor;
        [SerializeField] private Texture2D _crosshair;
        private Vector2 _offset = new Vector2(16, 16);

        public CursorType Type { get; private set; }

        private void Start()
        {
            SetCursor(_crosshair, _offset);
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
