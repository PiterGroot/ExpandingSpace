using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingForShooting : MonoBehaviour
{
    [SerializeField] private WaveSpawner spawner;
    [SerializeField] private int MoneyReward = 5;
    [SerializeField] private ParticleSystem explosion;
    public float MoveSpeed;
    private Rigidbody2D rb2d;
    public Vector2 MinMaxMoveSpeed;
    public int timer;
    // Start is called before the first frame update
    void Start()
    {
        timer = 700;
        spawner = FindObjectOfType<WaveSpawner>();
        rb2d = gameObject.GetComponent<Rigidbody2D>();
        MoveSpeed = Random.Range(MinMaxMoveSpeed.x, MinMaxMoveSpeed.y);
    }

    // Update is called once per frame
    void Update()
    {
        rb2d.velocity = new Vector2(-MoveSpeed, 0f);
        if (transform.position.x <= 7)
        {
            timer -= 1;
            if (timer <= 0)
            {
                rb2d.velocity = new Vector2(-MoveSpeed, 0f);
            }
            else
            {
                rb2d.velocity = new Vector2(0, 0f);
            }
        }
    }


    public void KillSelf()
    {
        FindObjectOfType<Wallet>().AddMoney(MoneyReward);
        FindObjectOfType<AudioManager>().Play("Coin");
        spawner.EnemyKilled();
        Instantiate(explosion, transform.position, Quaternion.identity);
        FindObjectOfType<AudioManager>().Play("Explosion");
        Destroy(gameObject);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Despawn"))
        {
            spawner.EnemyKilled();
            Destroy(gameObject);
        }
        if (collision.collider.CompareTag("Player"))
        {
            collision.collider.GetComponent<CollisionManager>().Health--;
            spawner.EnemyKilled();
            Destroy(gameObject);
        }
    }
}
