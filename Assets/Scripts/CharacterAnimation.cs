using UnityEngine;

[RequireComponent (typeof(SpriteRenderer))]
[RequireComponent(typeof(Animator))]
public class CharacterAnimation : MonoBehaviour
{
    private Animator _anim;

    private IMove _mover;

    private SpriteRenderer _spriteRenderer;

    private void Awake()
    {
        _anim = GetComponent<Animator>();
        _mover = GetComponent<IMove>();
        _spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        float _speed = _mover.Speed;
        _anim.SetFloat("Speed", Mathf.Abs(_speed));

        if (_speed != 0)
        {
            _spriteRenderer.flipX = _speed > 0;
        }
    }
}
