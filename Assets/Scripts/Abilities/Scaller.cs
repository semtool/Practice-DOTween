using UnityEngine;
using DG.Tweening;

public class Scaller : ItemAbilityer
{
    [SerializeField] private float _scale;

    public void ChangeScale(int numberCycles)
    {
        transform.DOScale(transform.localScale * _scale, Duration).SetEase(Ease.Linear).SetLoops(numberCycles, LoopType);
    }
}