using UnityEngine;

public class BeforeGameUI : MonoBehaviour
{
    public void StartGameBTN()
    {
        Player.Instance.GetPlayerData().currentState = GameState.InGame;
        UIManager.Instance.ChangeUIPanels();
    }
}
