using UnityEngine;
using DG.Tweening;

public class ColorChanger : MonoBehaviour
{
    [SerializeField] private Color _color;
    [SerializeField] private float _duration = 3f;

    private Color _originColor;
    private bool _isOriginColor = true;
    private Material _material;

    private void Start()
    {
        _material = GetComponent<Renderer>().material;
        _originColor = _material.color;

        ChangeObjectColor();
    }

    private void ChangeObjectColor()
    {
        if (_isOriginColor == true)
        {
            _material.DOColor(_color, _duration)
                .OnComplete(ReturnObjectColor)
                .SetEase(Ease.InSine); ;
        }
        else
        {
            ReturnObjectColor();
        }

        _isOriginColor = !_isOriginColor;
    }

    private void ReturnObjectColor()
    {
        _material.DOColor(_originColor, _duration)
            .OnComplete(ChangeObjectColor)
            .SetEase(Ease.InSine); ;
    }
}
