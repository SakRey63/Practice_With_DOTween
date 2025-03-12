using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class TextChanger : MonoBehaviour
{
    [SerializeField] private Text _text;
    [SerializeField] private string _startText;
    [SerializeField] private string _changeText;
    [SerializeField] private string _addText;
    [SerializeField] private float _duration;
    [SerializeField] private float _delay;
    [SerializeField] private ScrambleMode _scrambleMode;
    [SerializeField] private int _repeats;
    [SerializeField] private LoopType _loopType;
    [SerializeField] private Ease _ease;

    private Sequence _sequence;

    private void Awake()
    {
        _text.text = _startText;
    }

    private void Start()
    {
        _sequence = DOTween.Sequence();

        _sequence.Append(_text.DOText(_changeText, _duration).SetEase(_ease).SetDelay(_delay));
        _sequence.Append(_text.DOText(_addText, _duration).SetRelative().SetEase(_ease).SetDelay(_delay));
        _sequence.Append(_text.DOText(_startText, _duration, true, _scrambleMode).SetEase(_ease).SetDelay(_delay));
        _sequence.SetLoops(_repeats, _loopType);
    }
}