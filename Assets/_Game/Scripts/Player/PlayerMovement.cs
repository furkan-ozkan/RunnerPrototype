using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody _rigidbody;
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        if (Player.Instance.GetPlayerData().currentState == GameState.InGame)
        {
            _rigidbody.velocity = Vector3.left * Player.Instance.GetPlayerData().forwardSpeed;

            float lr = Input.GetAxisRaw("Horizontal");

            if (lr != 0)
            {
                _rigidbody.velocity = (Vector3.forward * Player.Instance.GetPlayerData().rightLeftSpeed * lr + Vector3.left)
                                      * Player.Instance.GetPlayerData().forwardSpeed;
            }
        }
    }
}
