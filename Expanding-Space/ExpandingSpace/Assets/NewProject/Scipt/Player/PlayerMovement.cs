using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //shop
    [SerializeField] Randomizer CallFunctionRandomizer1;
    [SerializeField] Randomizer CallFunctionRandomizer2;
    [SerializeField] Randomizer CallFunctionRandomizer3;

    // Game and Shop activeren
    [SerializeField] private GameObject SpaceShip;
    [SerializeField] private WaveSpawner spawner;
    [SerializeField]private GameObject HubFoundation;
    [SerializeField] private TriggerDialogue Shopkeep;
    [SerializeField] private TriggerDialogue SlakDia;
    
    //Walking
    public bool canMove;
    [SerializeField] private Rigidbody2D rb;
    public float speed = 4;


    //art
    [SerializeField] private GameObject RightWalk;
    [SerializeField] private GameObject LeftWalk;
    [SerializeField] private GameObject Standing;

    void Update()
    {
        if (canMove)
        {
            //Links
            if (Input.GetKey("a"))
            {
                rb.velocity = new Vector3(-speed, 0, 0);
                RightWalk.SetActive(true);
                LeftWalk.SetActive(false);
                Standing.SetActive(false);
            }
            //Rechts
            if (Input.GetKey("d"))
            {
                rb.velocity = new Vector3(speed, 0, 0);
                RightWalk.SetActive(false);
                LeftWalk.SetActive(true);
                Standing.SetActive(false);
            }

            if (Input.GetKeyUp("a"))
            {
                rb.velocity = new Vector3(0, 0, 0);
                RightWalk.SetActive(false);
                LeftWalk.SetActive(false);
                Standing.SetActive(true);
            }
            if (Input.GetKeyUp("d"))
            {
                rb.velocity = new Vector3(0, 0, 0);
                RightWalk.SetActive(false);
                LeftWalk.SetActive(false);
                Standing.SetActive(true);
            }
        }
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if(collision.gameObject.name == "Exit" && Input.GetKey(KeyCode.F)){

            if (PlayerPrefs.GetInt("Slak") != 1)
            {
                StartCoroutine(SlakDia.ActivateDialogue());
                PlayerPrefs.SetInt("Slak", 1);
                Invoke("Exits", 7);
                
            }
            else
            {
                Exits();
            }
        }
        if (collision.gameObject.tag == "Shop" && Input.GetKey(KeyCode.F))
        {
            Shopkeep.StartCoroutine(Shopkeep.ActivateDialogue());
            HubFoundation.SetActive(false);

        }
    }

    void Exits()
    {
        HubFoundation.SetActive(false);
        spawner.waitForPlayerChoice = true;
        SpaceShip.SetActive(true);
        CallFunctionRandomizer1.Randomized();
        CallFunctionRandomizer2.Randomized();
        CallFunctionRandomizer3.Randomized();
        FindObjectOfType<AudioManager>().Stop("OST");
    }
}
