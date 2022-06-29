using UnityEngine;

[CreateAssetMenu(menuName = "Data/Player/PlayerData")]
public class PlayerData : ScriptableObject
{
    #region Attributes

    public float forwardSpeed;
    public float rightLeftSpeed;

    public GameState currentState;

    #endregion
}
