using DG.Tweening;
using UnityEngine;

public class Scaled : MonoBehaviour
{
    [SerializeField] private Vector3 _scale;
    [SerializeField] private float _duration;
    [SerializeField] private LoopType _loopType;
    [SerializeField] private int _repeats;
    [SerializeField] private Ease _ease;

    private void Start()
    {
        transform.DOScale(_scale, _duration).SetLoops(_repeats, _loopType).SetEase(_ease);
    }
}