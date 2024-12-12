using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class TextChanger : MonoBehaviour
{
    [SerializeField] private Text _text;
    [SerializeField] private float _duration;

    private int _repeats = -1;

    private void Start()
    {
        Sequence sequence = DOTween.Sequence();

        sequence.Append(_text.DOText("������ �������� ���", _duration));
        sequence.Append(_text.DOText(", ��� �, � ���� ����", _duration).SetRelative());
        sequence.Append(_text.DOText("����������, ��� ���� � ��������", _duration, true, ScrambleMode.All));

        sequence.Play();

        sequence.SetLoops(_repeats);
    }
}