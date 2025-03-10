using DG.Tweening;
using UnityEngine;

public class ColorChanger : MonoBehaviour
{
    [SerializeField] private Color _color;
    [SerializeField] private float _duration;
    [SerializeField] private LoopType _loopType;
    [SerializeField] private int _numberOfLoops;

    private Material _material;

    private void Awake()
    {
        _material = gameObject.GetComponent<Renderer>().material;
    }

    private void Start()
    {
        ChangeColors();
    }

    private void ChangeColors()
    {
        _material.DOColor(_color, _duration).SetEase(Ease.Linear).SetLoops(_numberOfLoops, _loopType);
    }
}