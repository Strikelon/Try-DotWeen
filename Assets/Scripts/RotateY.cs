using UnityEngine;
using DG.Tweening;

public class RotateY : MonoBehaviour
{
    [SerializeField] private float _duration = 5f;

    private void Start()
    {
        transform.DORotate(new Vector3(0, 360, 0), _duration, RotateMode.LocalAxisAdd)
            .SetLoops(-1, LoopType.Incremental)
            .SetEase(Ease.Linear);
    }
}
