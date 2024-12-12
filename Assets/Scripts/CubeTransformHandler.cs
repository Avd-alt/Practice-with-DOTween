using DG.Tweening;
using UnityEngine;

public class CubeTransformHandler : MonoBehaviour
{
    [SerializeField] private Vector3 _directionRotate;
    [SerializeField] private Vector3 _directionScale;
    [SerializeField] private Vector3 _directionPosition;
    [SerializeField] private LoopType _loopType;
    [SerializeField] private float _duration;

    private int _repeats = -1;

    private void Start()
    {
        transform.DOMove(_directionPosition, _duration).SetLoops(_repeats, _loopType);
        transform.DORotate(_directionRotate, _duration).SetLoops(_repeats, _loopType);
        transform.DOScale(_directionScale, _duration).SetLoops(_repeats, _loopType);
    }
}