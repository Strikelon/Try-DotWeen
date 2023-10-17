using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class TextChanger : MonoBehaviour
{
    [SerializeField] private float _duration = 2f;
    [SerializeField] private Text _text;

    private void Start()
    {
        Sequence sequence = DOTween.Sequence();
        sequence.Append(_text.DOText("Замененный текст.", _duration));
        sequence.Append(_text.DOText(" Добавка к тексту", _duration).SetRelative());
        sequence.Append(_text.DOText("Взломано!", _duration, true, ScrambleMode.All));
        sequence.SetLoops(-1);
    }
}
