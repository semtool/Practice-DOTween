using UnityEngine;
using DG.Tweening;

public class Rotator : MonoBehaviour
{
    [SerializeField] private RotateMode _rotateMode;
    [SerializeField] private float _duration;
    [SerializeField] private LoopType _loopType;
    [SerializeField] private int _numberOfLoops;

    private float _rotateAngle = 360;

    private void Start()
    {
        Rotate();
    }

    private void Rotate()
    {
        transform.DORotate(new Vector3(0, _rotateAngle, 0), _duration, _rotateMode).SetEase(Ease.Linear).SetLoops(_numberOfLoops);
    }
}