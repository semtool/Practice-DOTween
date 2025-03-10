using UnityEngine;
using DG.Tweening;

public class Scaler : MonoBehaviour
{
    [SerializeField] private float _scale;
    [SerializeField] private float _duration;
    [SerializeField] private LoopType _loopType;
    [SerializeField] private int _numberOfLoops;

    private void Start()
    {
        ChangeScale();
    }
    private void ChangeScale()
    {
        transform.DOScale(transform.localScale * _scale, _duration).SetEase(Ease.Linear).SetLoops(_numberOfLoops, _loopType);
    }
}