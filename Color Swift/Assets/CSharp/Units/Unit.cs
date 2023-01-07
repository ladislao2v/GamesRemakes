using NTC.Global.Cache;
using UnityEngine;

public abstract class Unit : MonoCache
{
    virtual public void RotateUnit(float rotationSpeed)
    {
        transform.Rotate(0, 0, rotationSpeed * Time.deltaTime);
    }
}
