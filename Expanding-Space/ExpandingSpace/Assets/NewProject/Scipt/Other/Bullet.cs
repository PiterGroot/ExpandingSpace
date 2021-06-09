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
            Destroy(gameObject);
        }
    }
}
