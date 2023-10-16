using UnityEngine;
using DG.Tweening;

public class Scaling : MonoBehaviour
{
    [SerializeField] private Vector3 _targetScale;
    [SerializeField] private float _duration = 3f;

    private Vector3 _originalScale;
    private bool _isScalingUp = true;

    private void Start()
    {
        _originalScale = transform.localScale;

        StartScaling();
    }

    private void StartScaling()
    {
        if (_isScalingUp)
        {
            transform.DOScale(_targetScale, _duration)
                .OnComplete(StartScalingDown)
                .SetEase(Ease.OutSine);
        }
        else
        {
            StartScalingDown();
        }

        _isScalingUp = !_isScalingUp;
    }

    private void StartScalingDown()
    {
        transform.DOScale(_originalScale, _duration)
            .OnComplete(StartScaling)
            .SetEase(Ease.InSine);
    }
}
