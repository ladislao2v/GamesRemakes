using JetBrains.Annotations;
using NTC.Global.Cache;
using System.Collections.Generic;
using UnityEngine;

public class UnitSpawn : MonoCache
{
    [SerializeField] protected List<GameObject> unitList = new List<GameObject>();

    private Transform _camera;
    private Vector3 _lastPosition;

    private void Awake()
    {
        _camera = Get<Transform>();
        _lastPosition = _camera.position;
    }
    private void SpawnUnit()
    {
        while (true)
        {
            
        }
    }
}
