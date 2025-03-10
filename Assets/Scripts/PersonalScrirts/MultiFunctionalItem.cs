using UnityEngine;

[RequireComponent(typeof(Mover))]
[RequireComponent(typeof(Rotator))]
[RequireComponent(typeof(Scaller))]
public class MultiFunctionalItem : Unit
{
    private Mover _mover;
    private Rotator _rotator;
    private Scaller _scaller;

    private void Start()
    {
        _mover = GetComponent<Mover>();

        _rotator = GetComponent<Rotator>();

        _scaller = GetComponent<Scaller>();
    }

    public override void StartActivity(int numberCycles)
    {
        _mover.Move(numberCycles);

        _rotator.Rotate(numberCycles);

        _scaller.ChangeScale(numberCycles);
    }
}