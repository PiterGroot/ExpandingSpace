using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb2d;
    [SerializeField] private float moveSpeed = 3;
    private void OnTriggerEnter2D(Collider2D collision){
        if(collision.tag == "Player"){
            collision.gameObject.GetComponent<Wallet>().AddMoney(Random.Range(1, 3));
            Destroy(gameObject);
        }
    }
    private void Update()
    {
        rb2d.velocity = new Vector2(-moveSpeed, 0);
    }
}
