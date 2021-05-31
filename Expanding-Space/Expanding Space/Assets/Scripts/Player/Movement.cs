using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Movement : MonoBehaviour
{
    [SerializeField]private TriggerDialogue introTrigger;
    public bool canMove = true; 
    public Rigidbody2D rb;
    public int speed;
    [SerializeField] private float Playewidth;
 

    private void Start()
    {
        
    }
    void Update()
    {
        if (canMove)
        {
            //voor
            if (Input.GetKey("w"))
            {
                rb.velocity = new Vector3(0, speed, 0);
            }
            //rechts
            if (Input.GetKey("a"))
            {
               
                rb.velocity = new Vector3(-speed, 0, 0);
            }
            //achter
            if (Input.GetKey("s"))
            {
                rb.velocity = new Vector3(0, -speed, 0);
            }
            //links
            if (Input.GetKey("d"))
            {
               
                rb.velocity = new Vector3(speed, 0, 0);
            }


            //rechts boven
            if (Input.GetKey("w") && Input.GetKey("d"))
            {
                rb.velocity = new Vector3(speed, speed, 0f);
            }
            //rechts beneden
            if (Input.GetKey("s") && Input.GetKey("d"))
            {
                rb.velocity = new Vector3(speed, -speed, 0f);
            }
            //links boven
            if (Input.GetKey("w") && Input.GetKey("a"))
            {
                rb.velocity = new Vector3(-speed, speed, 0f);
            }
            //links beneden
            if (Input.GetKey("a") && Input.GetKey("s"))
            {
                rb.velocity = new Vector3(-speed, -speed, 0f);
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

    private void OnCollisionEnter2D(Collision2D collisionInfo)
    {
        if (collisionInfo.collider.tag == "wall")
        {
            rb.velocity = new Vector3(0, 0, 0);
        }
    }
    private void OnTriggerEnter2D(Collider2D other) {
        if(other.CompareTag("IntroTrigger")){
            introTrigger.StartCoroutine(introTrigger.ActivateDialogue());
            FindObjectOfType<StartExtraDialogue>().StartTimers();
            PlayerPrefs.SetInt("ColliderState", 1);
            StartCoroutine(Freeze());
            Destroy(other.gameObject);
        }
    }
    IEnumerator Freeze()
    {
        yield return new WaitForSeconds(.4f);
        canMove = false;
        rb.velocity = new Vector3(0, 0, 0);
    }
}


       