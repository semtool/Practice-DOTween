using UnityEngine;
using DG.Tweening;

public abstract class ItemAbilityer : MonoBehaviour
{
    [SerializeField] private float _duration;
    [SerializeField] private LoopType _loopType;

    public LoopType LoopType { get; private set; }

    public float Duration { get; private set; }


    private void Awake()
    {
        Duration = _duration;
        LoopType = _loopType;
    }
}