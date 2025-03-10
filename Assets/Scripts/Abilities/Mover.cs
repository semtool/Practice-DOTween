using UnityEngine;
using DG.Tweening;

public class Mover : ItemAbilityer
{
    [SerializeField] private float _endPositionY;

    public void Move(int infiniteNumber)
    {
        transform.DOMove(new Vector3(transform.position.x, _endPositionY, transform.position.z), Duration).
            SetEase(Ease.Linear).SetLoops(infiniteNumber, LoopType);
    }
}