using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObj : MonoBehaviour
{
    private bool _Magnitude;
    private Rigidbody2D rb2d;
    [SerializeField] private GameObject Particle;
    [SerializeField]private WaveSpawner spawner;
    [SerializeField]private bool canMove = true;
    [SerializeField]private float RotSpeed = 10;
    [SerializeField] private float MoveSpeed;
    public Vector2 MinMaxMoveSpeed;
    public Vector2 MinMaxSize = new Vector2(.8f, 1.2f);
    private void Start()
    {
        spawner = FindObjectOfType<WaveSpawner>();

        rb2d = gameObject.GetComponent<Rigidbody2D>();
        MoveSpeed = Random.Range(MinMaxMoveSpeed.x, MinMaxMoveSpeed.y);
        
        bool Magnitude = Random.value >= 0.5;
        _Magnitude = Magnitude;

        float randSize = Random.Range(MinMaxSize.x, MinMaxSize.y);
        gameObject.transform.localScale *= randSize;
    }
   
    // Update is called once per frame
    void Update()
    {
        if(this._Magnitude){
            transform.Rotate(new Vector3(0, 0, RotSpeed));
        }
        else{
            transform.Rotate(new Vector3(0, 0, -RotSpeed));
        }
        if(canMove){
            rb2d.velocity = new Vector2(-MoveSpeed, 0f);
        }
    }
    public void KillSelf()
    {
        spawner.EnemyKilled();
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
            Instantiate(Particle, transform.position, Quaternion.identity);
            RandomExplosionSound();
            spawner.EnemyKilled();
            Destroy(gameObject);
        }
    }

    private void RandomExplosionSound(){
        int randInt = Random.Range(0, 3);
        switch (randInt){
            case 0:
                FindObjectOfType<AudioManager>().Play("Explosion");
                break;
            case 1:
                FindObjectOfType<AudioManager>().Play("Explosion1");
                break;
            case 2:
                FindObjectOfType<AudioManager>().Play("Explosion2");
                break;
            case 3:
                FindObjectOfType<AudioManager>().Play("Explosion3");
                break;
        }
    }
}
