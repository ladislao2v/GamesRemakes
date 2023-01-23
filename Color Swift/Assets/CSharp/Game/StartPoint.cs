using NTC.Global.Cache;
using UnityEngine;

public class StartPoint : MonoCache
{
    private Transform _player;
    private Vector3 _startPosition;

    private void Awake()
    {
        _player = GetComponent<Transform>();
        _startPosition = _player.position;
    }

    protected override void Run()
    {
        if (_player.position.y < _startPosition.y)
            _player.position = _startPosition;
    }
}
