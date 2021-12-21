using UnityEngine;

namespace Assets.Scripts
{
    class CursorTracker : MonoBehaviour
    {
        [SerializeField] private Transform _head;
        [SerializeField] [Range(0, 10)] private float _bodyRotationSpeed;
        [SerializeField] [Range(0, 10)] private float _headRotationSpeed;

        private Camera _camera;
        private InputHandler _inputHandler;

        private void Awake()
        {
            _camera = Camera.main;
            _inputHandler = new InputHandler();
        }

        private void Update()
        {
            Vector2 inputMousePosition = _inputHandler.CharacterControls.Look.ReadValue<Vector2>();

            Vector3 cursorPosition = _camera.ScreenToWorldPoint(new Vector3
            (
                inputMousePosition.x,
                inputMousePosition.y,
                _camera.transform.position.y)
            );

            Look(cursorPosition, transform, _bodyRotationSpeed);
            Look(new Vector3(cursorPosition.x, 1, cursorPosition.z), _head, _headRotationSpeed);
        }

        private void Look(Vector3 target, Transform exceptor, float rotationSpeed)
        {
            Vector3 direction = target - exceptor.position;
            Quaternion lookRotation = Quaternion.LookRotation(direction);
            exceptor.rotation = Quaternion.Lerp(exceptor.rotation, lookRotation, rotationSpeed * Time.deltaTime);
        }

        private void OnEnable()
        {
            _inputHandler.Enable();
        }

        private void OnDisable()
        {
            _inputHandler.Disable();
        }
    }
}
