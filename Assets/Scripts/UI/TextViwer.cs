using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class TextViewer : MonoBehaviour
{
    private const string FirsText = "«¿Ã≈Õ¿";
    private const string SecondText = " + ƒŒ¡¿¬ ¿";
    private const string ThirdText = "«¿Ã≈Õ¿ œ≈–≈¡Œ–ŒÃ.";

    [SerializeField] private LoopType _loopType;
    [SerializeField] private Text _textOne;

    private void Start()
    {
        Sequence sequence = DOTween.Sequence();

        sequence.Insert(2f,(_textOne.DOText(FirsText, 1)));

        sequence.Append(_textOne.DOText(SecondText, 2).SetRelative());

        sequence.Append(_textOne.DOText(ThirdText, 2, false, ScrambleMode.All));

        sequence.SetLoops(-1, _loopType);
    }
}
