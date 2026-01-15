using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 12f;
    public float lifetime = 2f;
    public int damage = 1;

    Rigidbody2D _rigidbody;
    [SerializeField] private LayerMask enemyLayer;

    void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    void Start()
    {
        Destroy(gameObject, lifetime);
    }

    public void SetDirection(Vector2 direction)
    {
        _rigidbody.linearVelocity = direction.normalized * speed;
    }

    void OnTriggerEnter2D(Collider2D enemy)
    {
        if (((1 << enemy.gameObject.layer) & enemyLayer) != 0)
        {
            enemy.GetComponent<EnemyHealth>()?.TakeDamage(damage);
            Destroy(gameObject);
        } 
    }

}
