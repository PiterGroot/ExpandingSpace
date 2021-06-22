using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemieBullet : MonoBehaviour
{
    public PowerUpManager powerUpManager;
    public Health health;
    [HideInInspector] public CollisionManager collisionManager;



    private void Start()
    {
        collisionManager = FindObjectOfType<CollisionManager>();
    }
    void Update()
    {
        transform.Translate(new Vector2(-12, 0) * Time.deltaTime);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Player")
        {
            if (collisionManager.shield > 0)
            {
                collision.gameObject.GetComponent<CollisionManager>().shield--;
                Destroy(gameObject);
            }
            else
            {
                collision.gameObject.GetComponent<CollisionManager>().Health--;
                Destroy(gameObject);
            }

        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "DespawnBullet")
        {
            Destroy(gameObject);
        }
    }
}
