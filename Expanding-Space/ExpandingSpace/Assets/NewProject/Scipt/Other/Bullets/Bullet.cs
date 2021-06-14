using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private GameObject MeteorExplosion;
    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector2(5, 0) * Time.deltaTime);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Meteor")
        {
            collision.gameObject.GetComponent<MoveObj>().KillSelf();
            Instantiate(MeteorExplosion, transform.position, Quaternion.identity);
            RandomExplosionSound();
            Destroy(gameObject);
        }
        if (collision.collider.tag == "Snail")
        {
            collision.gameObject.GetComponent<Moving>().KillSelf();
            Destroy(gameObject);
        }

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "DespawnBullet")
        {
            Destroy(gameObject);
        }
    }
    private void RandomExplosionSound()
    {
        int randInt = Random.Range(0, 3);
        switch (randInt)
        {
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
