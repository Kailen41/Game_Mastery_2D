using UnityEngine;

[RequireComponent(typeof(CharacterGrounding))]
[RequireComponent(typeof(Rigidbody2D))]
public class PlayerController : MonoBehaviour, IMove
{
    [SerializeField]
    private float _moveSpeed = 4.0f;
    [SerializeField]
    private float _jumpForce = 400.0f;

    private Rigidbody2D _rb2D;

    private CharacterGrounding _characterGrounding;

    public float Speed { get; private set; }

    private void Awake()
    {
        _rb2D = GetComponent<Rigidbody2D>();
        _characterGrounding = GetComponent<CharacterGrounding>();
    }

    private void Update()
    {
        float _horizontal = Input.GetAxis("Horizontal");
        Speed = Mathf.Abs(_horizontal);

        Vector3 _movement = new Vector3(_horizontal, 0);

        transform.position += _movement * Time.deltaTime * _moveSpeed;

        if (Input.GetKeyDown(KeyCode.W) && _characterGrounding.IsGroudned)
        {
            _rb2D.AddForce(Vector2.up * _jumpForce);
        }
    }
}
