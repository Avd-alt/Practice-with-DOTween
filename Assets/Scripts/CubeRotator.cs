using UnityEngine;
using DG.Tweening;

public class CubeRotator : MonoBehaviour
{
    [SerializeField] private Vector3 _direction;
    [SerializeField] private RotateMode _rotateMode;
    [SerializeField] private float _duration;
    [SerializeField] private LoopType _loopType;

    private int _repeats = -1;

    private void Start()
    {
        transform.DORotate(_direction, _duration, _rotateMode).SetLoops(_repeats, _loopType);
    }
}