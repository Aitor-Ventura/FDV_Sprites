using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieDummy : MonoBehaviour
{
    private Animator _animator;

    private void Start()
    {
        _animator = gameObject.GetComponent<Animator>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            _animator.SetBool($"isDying", true);
        }
    }
}
