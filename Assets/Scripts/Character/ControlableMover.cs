using System;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts
{
    [RequireComponent(typeof(CharacterController), typeof(Animator))]
    class ControlableMover : MonoBehaviour
    {
        [SerializeField] [Range(1, 10)] private float _moveSpeed;

        private InputHandler _inputHandler;
        private CharacterController _controller;
        private Vector2 _moveInput;
        private Animator _animator;

        private void Awake()
        {
            _controller = GetComponent<CharacterController>();
            _inputHandler = new InputHandler();
            _animator = GetComponent<Animator>();
        }

        private void FixedUpdate()
        {
            _moveInput = _inputHandler.CharacterControls.Movement.ReadValue<Vector2>();
            Vector3 motion = new Vector3(_moveInput.x, 0, _moveInput.y);
            float motionX = Vector3.Dot(motion.normalized, transform.right);
            float motionY = Vector3.Dot(motion.normalized, transform.forward);
            _controller.Move(motion * _moveSpeed * Time.fixedDeltaTime);
            _animator.SetFloat(Animations.Parameters.MotionX, motionX);
            _animator.SetFloat(Animations.Parameters.MotionY, motionY);
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
