using UnityEngine; 

public class GameManager : MonoBehaviour
{
    [SerializeField] private Material _material;
    void Awake()
    {
        Player.Instance.GetPlayerData().currentState = GameState.BeforeGame;
        _material.color = Color.white;
        _material.SetColor("_EmissionColor", Color.white);
    }
}
