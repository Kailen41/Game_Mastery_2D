using UnityEngine;

public class KillOnTouch : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D _otherGameObject)
    {
        var _playerController = _otherGameObject.collider.GetComponent<PlayerController>();

        if (_playerController != null)
        {
            GameManager.Instance.KillPlayer();
        }
    }
}
