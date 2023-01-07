using UnityEngine;

public class UnitCircle : Unit
{
    [Header("Rotation Speed")]
    [SerializeField] private float _rotationSpeed = 95f;

    protected override void Run()
    {
        RotateUnit(_rotationSpeed);
    }

    public override void RotateUnit(float rotationSpeed)
    {
        base.RotateUnit(rotationSpeed);
    }

}
