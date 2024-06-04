using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance {get; private set;}
    public int Lives {get; private set;}

    public event Action<int> OnLivesChanged;
    public event Action<int> OnLCoinsChanged;

    private int _coins;

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);

            RestartGame();
        }
    }

    internal void AddCoin()
    {
        _coins++;

        if (OnLCoinsChanged != null)
        {
            OnLCoinsChanged(_coins);
        }
    }

    internal void KillPlayer()
    {
        Lives--;
        if (OnLivesChanged != null)
        {
            OnLivesChanged(Lives);
        }

        if (Lives <= 0)
        {
            RestartGame();
        }
    }

    private void RestartGame()
    {
        Lives = 3;

        if (OnLivesChanged != null)
        {
            OnLivesChanged(Lives);
        }

        _coins = 0;
        SceneManager.LoadScene(0);
    }
}
