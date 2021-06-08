using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private GameObject SpaceShip;
    [SerializeField] private WaveSpawner spawner;
    [SerializeField]private GameObject HubFoundation;
    [SerializeField] private GameObject Shop;
    public bool canMove;
    [SerializeField] private Rigidbody2D rb;
    public float speed = 4;
    void Update()
    {
        if (canMove)
        {
            //rechts
            if (Input.GetKey("a"))
            {
                rb.velocity = new Vector3(-speed, 0, 0);
            }
            //links
            if (Input.GetKey("d"))
            {
                rb.velocity = new Vector3(speed, 0, 0);
            }

            if (Input.GetKeyUp("w"))
            {
                rb.velocity = new Vector3(0, 0, 0);
            }

            if (Input.GetKeyUp("a"))
            {
                rb.velocity = new Vector3(0, 0, 0);
            }

            if (Input.GetKeyUp("s"))
            {
                rb.velocity = new Vector3(0, 0, 0);
            }

            if (Input.GetKeyUp("d"))
            {
                rb.velocity = new Vector3(0, 0, 0);
            }
        }
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if(collision.gameObject.name == "Exit" && Input.GetKey(KeyCode.F)){
            HubFoundation.SetActive(false);
            spawner.waitForPlayerChoice = true;
            SpaceShip.SetActive(true);
            FindObjectOfType<AudioManager>().Stop("OST");
        }
        if (collision.gameObject.tag == "Shop" && Input.GetKey(KeyCode.F))
        {
            HubFoundation.SetActive(false);
            Shop.SetActive(true);


        }
    }
}
