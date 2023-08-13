using System;
using UnityEngine;

namespace Controls
{
    public class KolyanController : MonoBehaviour
    {
        [SerializeField] private Rigidbody2D _rigidbody;
        [SerializeField] private float _powerJump;
        [SerializeField] private float _speed;
        
        private KolyanControls _controls;
        private float _moveInput;
        private void Awake()
        {
            _controls = new KolyanControls();
            _controls.main.Jump.performed += ctx => Jump();
        }

        private void Jump()
        {
            _rigidbody.velocity = new Vector2(_rigidbody.velocity.x, _powerJump);
        }

        private void OnEnable()
        {
            _controls.Enable();
        }

        private void OnDisable()
        {
            _controls.Disable();
        }

        private void FixedUpdate()
        {
            Move();
        }

        private void Move()
        {
            _moveInput = 0;
            _moveInput = _controls.main.Move.ReadValue<float>();
            if (_moveInput == 1)
            {   Debug.Log("1");
                _rigidbody.velocity = new Vector2(_speed, _rigidbody.velocity.y);
            } else if (_moveInput == -1)
            {   
                Debug.Log("-1");
                _rigidbody.velocity = new Vector2(-_speed, _rigidbody.velocity.y);
            }
        }
    }
}
