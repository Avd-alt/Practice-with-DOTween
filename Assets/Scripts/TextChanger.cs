using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class TextChanger : MonoBehaviour
{
    private const string _textForReplacement = "������ �������� ���";
    private const string _textForAdd = ", ��� �, � ���� ����";
    private const string _textForShake = "����������, ��� ���� � ��������";

    [SerializeField] private Text _text;
    [SerializeField] private float _duration;

    private int _repeats = -1;

    private void Start()
    {
        Sequence sequence = DOTween.Sequence();

        sequence.Append(_text.DOText(_textForReplacement, _duration));
        sequence.Append(_text.DOText(_textForAdd, _duration).SetRelative());
        sequence.Append(_text.DOText(_textForShake, _duration, true, ScrambleMode.All));

        sequence.Play();

        sequence.SetLoops(_repeats);
    }
}