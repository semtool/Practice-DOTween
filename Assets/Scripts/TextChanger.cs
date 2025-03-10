using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class TextChanger : MonoBehaviour
{
    private const string FirsText = "«¿Ã≈Õ¿";
    private const string SecondText = " + ƒŒ¡¿¬ ¿";
    private const string ThirdText = "«¿Ã≈Õ¿ œ≈–≈¡Œ–ŒÃ.";

    [SerializeField] private LoopType _loopType;
    [SerializeField] private Text _textOne;
    [SerializeField] private int _numberOfLoops;

    private float _startDelay = 2f;
    private float _duration = 2f;
    private bool _richTextEnabled = false;

    private void Start()
    {
        Sequence sequence = DOTween.Sequence();

        sequence.Insert(_startDelay, (_textOne.DOText(FirsText, _duration)));

        sequence.Append(_textOne.DOText(SecondText, _duration).SetRelative());

        sequence.Append(_textOne.DOText(ThirdText, _duration, _richTextEnabled, ScrambleMode.All));

        sequence.SetLoops(_numberOfLoops, _loopType);
    }
}