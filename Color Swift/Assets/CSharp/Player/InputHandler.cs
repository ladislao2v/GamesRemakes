using NTC.Global.Cache;
using UnityEngine;

public class InputHandler : MonoCache
{
    private IJumpable _jumpable;

    private void Awake()
    {
        _jumpable = GetComponent<IJumpable>();
    }

    protected override void Run()
    {
        if (Input.GetMouseButtonDown(0))
            _jumpable.Jump();
    }
}
