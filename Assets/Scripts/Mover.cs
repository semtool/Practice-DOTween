using UnityEngine;
using DG.Tweening;

public class Mover : MonoBehaviour
{
    [SerializeField] private float _endPositionY;
    [SerializeField] private float _duration;
    [SerializeField] private LoopType _loopType;
    [SerializeField] private int _numberOfLoops;

    private void Start()
    {
        Move();
    }

    private void Move()
    {
        transform.DOMove(new Vector3(transform.position.x, _endPositionY, transform.position.z), _duration).
            SetEase(Ease.Linear).SetLoops(_numberOfLoops, _loopType);
    }
}