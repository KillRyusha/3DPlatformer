using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float _movementSpeed;
    [SerializeField] private float _jumpForce;
    [SerializeField] private Animator _playerAnimator;
    [SerializeField] private Vector3 _groundCheckOffset;
    [SerializeField] private float _groundCheckRadius;
    [SerializeField] private float _hitDistance;
    [SerializeField] private LayerMask _groundMask;
    private Rigidbody _rigidbody;
    private float _horizontalMovement;
    private float _verticalMovement;
    private bool _onGround;
    private RaycastHit _hit;

    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        _horizontalMovement = Input.GetAxis("Horizontal");
        _verticalMovement = Input.GetAxis("Vertical");

        if (_horizontalMovement != 0 || _verticalMovement != 0)
        {
            _rigidbody.velocity = new Vector3(
                _horizontalMovement * _movementSpeed, 
                _rigidbody.velocity.y,
                _verticalMovement * _movementSpeed);
            _playerAnimator.SetBool("Move", true);
        }
        else
        {
            _playerAnimator.SetBool("Move", false);
        }

        _onGround = Physics.SphereCast(transform.position - _groundCheckOffset, _groundCheckRadius, Vector3.down, out _hit , _hitDistance, _groundMask);
       
        if (Input.GetKeyDown(KeyCode.Space) && _onGround)
        {
            _rigidbody.AddForce(
                Vector3.up * _jumpForce,
                ForceMode.Impulse);
            _playerAnimator.SetBool("Jump", true);
        }
        else if(_onGround)
        {
            _playerAnimator.SetBool("Jump", false);
        }
    }
}
