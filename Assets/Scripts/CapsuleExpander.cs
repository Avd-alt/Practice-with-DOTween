using UnityEngine;
using DG.Tweening;

public class CapsuleExpander : MonoBehaviour
{
    [SerializeField] private Vector3 _maxSize;
    [SerializeField] private float _duration;
    [SerializeField] private LoopType _loopType;

    private int _repeats = -1;

    private void Start()
    {
        transform.DOScale(_maxSize, _duration).SetLoops(_repeats, _loopType);
    }
}