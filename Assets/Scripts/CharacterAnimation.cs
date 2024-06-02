using UnityEngine;

public class CharacterAnimation : MonoBehaviour
{
    private Animator _anim;

    private IMove _mover;

    private void Awake()
    {
        _anim = GetComponent<Animator>();
        _mover = GetComponent<IMove>();
    }

    private void Update()
    {
        float _speed = _mover.Speed;

        _anim.SetFloat("Speed", _speed);
    }
}
