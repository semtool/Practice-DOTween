using UnityEngine;

[RequireComponent(typeof(Colorer))]
public class ColoringItem : Unit
{
    private Colorer _colorer;
    void Start()
    {
        _colorer = GetComponent<Colorer>();
    }

    public override void StartActivity(int numberCycles)
    {
        _colorer.ChangeColors(numberCycles);
    }
}