using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class FirstPlayerDonutController : MonoBehaviour
{
    [SerializeField] private Vector3 _jumpLengthRight;
    [SerializeField] private Vector3 _jumpLengthLeft;
    [SerializeField] private float _jumpForce;

    private Rigidbody _rigidbody;
    private Material _material;
    
    void Awake()
    {
        _material = GetComponent<Material>();
        _rigidbody = GetComponent<Rigidbody>();
        _rigidbody.isKinematic = true;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
            JumpLeft();
        if (Input.GetKeyDown(KeyCode.D))
            JumpRight();
    }

    private void Jump(Vector3 jumpDirection)
    {
        _rigidbody.isKinematic = false;
        _rigidbody.velocity = Vector3.zero;
        _rigidbody.AddForce(jumpDirection * _jumpForce, ForceMode.Impulse);
    }

    private void JumpRight()
    {
        Jump(_jumpLengthRight);
    }

    private void JumpLeft()
    {
        Jump(_jumpLengthLeft);
    }
    
    
}
