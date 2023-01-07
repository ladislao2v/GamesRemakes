using NTC.Global.Cache;
using UnityEngine;

public class PlayerMove : MonoCache, IControllable
{
    [SerializeField] private float _jumpForce;

    private Rigidbody2D _rigidbody;
    private void Awake()
    {
        _rigidbody = Get<Rigidbody2D>();
    }

    protected override void Run()
    {
        CheckIteraction();
    }

    private void CheckIteraction()
    {
        if (Input.GetMouseButtonDown(0))
            Jump();
    }

    private void Jumping()
    {
        _rigidbody.velocity = Vector2.up * _jumpForce;
    }

    public void Jump()
    {
        Jumping();
    }
}    
