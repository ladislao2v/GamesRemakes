using NTC.Global.Cache;
using UnityEngine;

public class PlayerMove : MonoCache, IJumpable
{
    [SerializeField] private float _jumpForce;

    private Rigidbody2D _rigidbody;
    private void Awake()
    {
        _rigidbody = Get<Rigidbody2D>();
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
