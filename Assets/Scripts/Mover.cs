using UnityEngine;
using DG.Tweening;

public class Mover : MonoBehaviour
{
    [SerializeField] private Vector3 _position;
    [SerializeField] private float _duration;
    [SerializeField] private LoopType _loopType;
    [SerializeField] private int _repeats;
    [SerializeField] private Ease _ease;
    
    private void Start()
    {
        transform.DOMove(_position, _duration).SetLoops(_repeats, _loopType).SetEase(_ease);
    }
}