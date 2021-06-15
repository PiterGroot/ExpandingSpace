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
    private FlipSpriteScale flip;

    //art
    [SerializeField] private GameObject RightWalk;
    [SerializeField] private GameObject LeftWalk;
    [SerializeField] private GameObject Standing;

    public Sprite DownSprite;

    private void Start()
    {
        
    }
    void Update()
    {
        if (canMove)
        {


            //rechts
            if (Input.GetKey("a"))
            {
                rb.velocity = new Vector3(-speed, 0, 0);
                RightWalk.SetActive(true);
                LeftWalk.SetActive(false);
                Standing.SetActive(false);
            }
            //links
            if (Input.GetKey("d"))
            {
                rb.velocity = new Vector3(speed, 0, 0);
                RightWalk.SetActive(true);
                LeftWalk.SetActive(false);
                Standing.SetActive(false);
            }


            if (Input.GetKeyUp("a"))
            {
                rb.velocity = new Vector3(0, 0, 0);
                RightWalk.SetActive(true);
                LeftWalk.SetActive(false);
                Standing.SetActive(false);
            }

            if (Input.GetKeyUp("d"))
            {
                rb.velocity = new Vector3(0, 0, 0);
                RightWalk.SetActive(true);
                LeftWalk.SetActive(false);
                Standing.SetActive(false);
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


       