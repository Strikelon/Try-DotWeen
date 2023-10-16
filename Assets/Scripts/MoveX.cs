using DG.Tweening;
using UnityEngine;

public class MoveX : MonoBehaviour
{
    [SerializeField] private float _moveDistance = 10f;
    [SerializeField] private float _duration = 5f;

    private Vector3 _startPosition;
    private float _halfDuration;

    private void Start()
    {
        _startPosition = transform.position;
        _halfDuration = _duration / 2f;

        MoveObject();
    }

    private void MoveObject()
    {
        transform.DOMoveX(_startPosition.x + _moveDistance, _halfDuration)
            .SetEase(Ease.InOutSine)
            .OnComplete(MoveBackward);
    }

    private void MoveBackward()
    {
        transform.DOMoveX(_startPosition.x, _halfDuration)
            .SetEase(Ease.InOutSine)
            .OnComplete(MoveObject);
    }
}
