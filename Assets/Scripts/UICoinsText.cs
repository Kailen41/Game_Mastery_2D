using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UICoinsText : MonoBehaviour
{
    private TextMeshProUGUI _textMeshPro;

    private void Awake()
    {
        _textMeshPro = GetComponent<TextMeshProUGUI>();      
    }

    void Start()
    {
        GameManager.Instance.OnLCoinsChanged += HandleOnLCoinsChanged;
    }

    private void HandleOnLCoinsChanged(int coins)
    {
        _textMeshPro.text = coins.ToString();
    }
}
