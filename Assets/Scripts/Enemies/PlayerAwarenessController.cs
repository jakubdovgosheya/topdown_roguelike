using UnityEngine;

public class PlayerAwarenessController : MonoBehaviour
{
    public bool AwareOfPlayer {  get; private set; }
    public Vector2 DirectionToPlayer { get; private set; }

    [SerializeField] private float _playerAwarenessDistance;
    [SerializeField] private float _playerMinDistance;

    private Transform _player;

    private void Awake()
    {
        _player = Object.FindFirstObjectByType<PlayerMovement>().transform;
    }

  
    void Update()
    {
        Vector2 enemyToPlayerVector = _player.position - transform.position;
        DirectionToPlayer = enemyToPlayerVector.normalized;

        if (enemyToPlayerVector.magnitude <= _playerAwarenessDistance && enemyToPlayerVector.magnitude >= _playerMinDistance)
        {
            AwareOfPlayer = true;

           
        }
        else
        {
            AwareOfPlayer = false;
        }
    }
}
