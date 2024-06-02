using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterGrounding : MonoBehaviour
{
    [SerializeField]
    private Transform _leftFoot;
    [SerializeField]
    private Transform _rightFoot;

    [SerializeField]
    private float _maxDistance;

    [SerializeField]
    private LayerMask _groundMask;

    public bool IsGroudned { get; private set; }

    private void Update()
    {
        CheckFootForGrounding(_leftFoot);

        if (IsGroudned == false)
        {
            CheckFootForGrounding(_rightFoot);
        }
    }

    private void CheckFootForGrounding(Transform _foot)
    {
        var _raycastHit = Physics2D.Raycast(_foot.position, Vector2.down, _maxDistance, _groundMask);
        Debug.DrawRay(_foot.position, Vector3.down * _maxDistance, Color.red);

        if (_raycastHit.collider != null)
        {
            IsGroudned = true;
        }
        else
        {
            IsGroudned = false;
        }
    }
}