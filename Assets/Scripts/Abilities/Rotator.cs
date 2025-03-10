using UnityEngine;
using DG.Tweening;

public class Rotator : ItemAbilityer
{
    [SerializeField] private RotateMode _rotateMode;

    private float _rotateAngle = 360;

    public void Rotate(int infiniteNumber)
    {
        transform.DORotate(new Vector3(0, _rotateAngle, 0), Duration, _rotateMode).SetEase(Ease.Linear).SetLoops(infiniteNumber);
    }
}