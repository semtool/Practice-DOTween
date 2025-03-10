using UnityEngine;

[RequireComponent(typeof(Scaller))]
public class ScalableItem : Unit
{
    private Scaller _scaller;

    void Start()
    {
        _scaller = GetComponent<Scaller>();
    }

    public override void StartActivity(int numberCycles)
    {
        _scaller.ChangeScale(numberCycles);
    }
}