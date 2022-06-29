using UnityEngine;

public class CameraFollowPlayer : MonoBehaviour
{
    private Vector3 _distance;
    [SerializeField] private GameObject _player;
    void Start()
    {
        _distance = transform.position - _player.transform.position;
    }
    void LateUpdate()
    {
        transform.position = _player.transform.position + _distance;
    }
}
