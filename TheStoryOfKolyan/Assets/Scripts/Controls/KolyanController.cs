using System;
using System.Collections.Generic;
using Gun;
using UnityEngine;

namespace Controls
{
    public class KolyanController : MonoBehaviour
    {
        [SerializeField] private Rigidbody2D _rigidbody;
        [SerializeField] private float _powerJump;
        [SerializeField] private float _speed;
        [SerializeField] private bool _isGrounded;
        
        private KolyanControls _controls;
        private float _moveInput;
        private BulletState _bulletState;

        private void Start()
        {
            _bulletState = BulletState.Default;
        }
        
        private void Awake()
        {
            _controls = new KolyanControls();
            _controls.main.Jump.performed += ctx => Jump();
            _controls.main.Shoot.performed += ctx => Shot();
        }
        
        private void OnCollisionStay2D(Collision2D other)
        {
            _isGrounded = true;

        }

        private void OnCollisionExit2D(Collision2D other)
        {
            _isGrounded = false;
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

        private void Jump()
        {
            if (_isGrounded)
            {
                _rigidbody.velocity = new Vector2(_rigidbody.velocity.x, _powerJump);
            }
        }
        
        private void Move()
        {
            _moveInput = 0;
            _moveInput = _controls.main.Move.ReadValue<float>();
            if (_moveInput == 1)
            {
                transform.rotation = Quaternion.Euler(0, 0, 0);
                _rigidbody.velocity = new Vector2(_speed, _rigidbody.velocity.y);
            }
            else if (_moveInput == -1)
            {
                transform.rotation = Quaternion.Euler(0, 180, 0);
                _rigidbody.velocity = new Vector2(-_speed, _rigidbody.velocity.y);
            }
        }
        private void Shot()
        {
            Debug.Log(" Shot");
            switch (_bulletState)
            {
                case   BulletState.YourMouth:
                    break;
                case   BulletState.YourAss:
                    break;
                case   BulletState.YourTongue:
                    break;
                case   BulletState.Default:
                    break;
            }
        }
    }
}
