using UnityEngine;

public class Player : MonoBehaviour
{

    #region Singleton

    public static Player Instance;

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
    
    [SerializeField] private PlayerData _playerData;

    public PlayerData GetPlayerData()
    {
        return _playerData;
    }
}
