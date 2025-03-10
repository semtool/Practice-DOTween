using DG.Tweening;
using UnityEngine;

public class Colorer : ItemAbilityer
{
    [SerializeField] private Color _color;

    private Material _material;

    private void Start()
    {
        _material = gameObject.GetComponent<Renderer>().material;
    }

    public void ChangeColors(int numberCycles)
    {
        _material.DOColor(_color, Duration).SetEase(Ease.Linear).SetLoops(numberCycles, LoopType);
    }
}