using System;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    #region Singleton

    public static UIManager Instance;

    private void Awake()
    {
        if (Instance == null)
        {
            DontDestroyOnLoad(gameObject);
            Instance = this;
        }
        else if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
        }
    }

    #endregion

    public GameObject beforeGame, inGame, endGame;
    
    public void ChangeUIPanels()
    {
        beforeGame.SetActive(false);
        inGame.SetActive(false);
        endGame.SetActive(false);
        if (Player.Instance.GetPlayerData().currentState == GameState.BeforeGame)
        {
            beforeGame.SetActive(true);
        }
        else if (Player.Instance.GetPlayerData().currentState == GameState.InGame)
        {
            inGame.SetActive(true);
        }
        else if (Player.Instance.GetPlayerData().currentState == GameState.EndGame)
        {
            endGame.SetActive(true);
        }
    }
}
