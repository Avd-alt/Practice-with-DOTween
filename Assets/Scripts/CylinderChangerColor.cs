using DG.Tweening;
using UnityEngine;

public class CylinderChangerColor : MonoBehaviour
{
    [SerializeField] private MeshRenderer _renderer;
    [SerializeField] private Color _color;
    [SerializeField] private float _duration;
    [SerializeField] private LoopType _loopType;

    private int _repeats = -1;

    private void Start()
    {
        _renderer.material.DOColor(_color, _duration).SetLoops(_repeats, _loopType);
    }
}