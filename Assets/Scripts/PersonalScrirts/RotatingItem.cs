using DG.Tweening;
using UnityEngine;

[RequireComponent(typeof(Rotator))]
public class RotatingItem : Unit
{
    private Rotator _rotator;

    private void Start()
    {
        _rotator = GetComponent<Rotator>();
    }

    public override void StartActivity(int numberCycles)
    {
        _rotator.Rotate(numberCycles);
    }
}