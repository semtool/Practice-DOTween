using UnityEngine;

[RequireComponent(typeof(Mover))]
public class MovingItem : Unit
{
    private Mover _mover;

    private void Start()
    {
        _mover = GetComponent<Mover>();
    }

    public override void StartActivity(int numberCycles)
    {
        _mover.Move(numberCycles);
    }
}
