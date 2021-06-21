using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossBullet : MonoBehaviour
{
    [SerializeField]private float Speed = 8;
    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector2(Speed, 0) * Time.deltaTime);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Player")
        {
            collision.gameObject.GetComponent<CollisionManager>().Health--;
            Destroy(gameObject);
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
