using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private float _moveSpeed = 4.0f;
    [SerializeField]
    private float _jumpForce = 400.0f;

    private Rigidbody2D _rb2D;

    private void Awake()
    {
        _rb2D = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float _horizontal = Input.GetAxis("Horizontal");

        Vector3 _movement = new Vector3(_horizontal, 0);

        transform.position += _movement * Time.deltaTime * _moveSpeed;

        if (Input.GetKeyDown(KeyCode.W))
        {
            _rb2D.AddForce(Vector2.up * _jumpForce);
        }
    }
}
