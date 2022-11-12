using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieMovement : MonoBehaviour
{
    [SerializeField] private float _speed = 5f;
    [SerializeField] private float _jumpForce = 250f;

    private SpriteRenderer _spriteRenderer;
    private Animator _animator;
    private Rigidbody2D _rigidbody;

    private void Start()
    {
        _spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        _animator = gameObject.GetComponent<Animator>();
        _rigidbody = gameObject.GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        _animator.SetBool($"isWalking", Input.GetAxisRaw("Horizontal") != 0);
        _spriteRenderer.flipX = Input.GetAxisRaw("Horizontal") < 0f;
        transform.Translate(Vector3.right * (Input.GetAxis("Horizontal") * _speed * Time.deltaTime));

        if (Input.GetKeyDown(KeyCode.Space))
        {
            _rigidbody.AddForce(_jumpForce * Vector2.up);
        }
    }
}
