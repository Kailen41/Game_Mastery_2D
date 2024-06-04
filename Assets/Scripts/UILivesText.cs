using UnityEngine;
using TMPro;

public class UILivesText : MonoBehaviour
{
    private TextMeshProUGUI _textMeshPro;

    private void Awake()
    {
        _textMeshPro = GetComponent<TextMeshProUGUI>();
    }

    private void Start()
    {
        GameManager.Instance.OnLivesChanged += HandleOnLivesChanged;
        _textMeshPro.text = GameManager.Instance.Lives.ToString();
    }

    private void HandleOnLivesChanged(int _livesRemaining)
    {
        _textMeshPro.text = _livesRemaining.ToString();
    }
}
