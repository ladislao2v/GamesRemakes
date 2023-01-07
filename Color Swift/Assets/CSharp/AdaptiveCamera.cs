using NTC.Global.Cache;
using UnityEngine;

public class AdaptiveCamera : MonoCache
{
    [SerializeField] private Transform _player;
    private Transform _camera;

    private void Awake()
    {
        _camera = Get<Transform>();
    }
    protected override void Run()
    {
        if (_player.position.y > _camera.position.y)
            _camera.position = new Vector3(_camera.position.x, _player.position.y, _camera.position.z);
    }
}
