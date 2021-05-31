


    using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LVL2MovementScript : MonoBehaviour
{
    public Rigidbody2D rb;
    public int speed;
    public GameObject SlowIcon;
    public float timer = 0;
    public float GameTimer = 20;

    //art
    public SpriteRenderer spriteRenderer;
    public Sprite LSprite;
    public Sprite RSprite;
    public Sprite UpSprite;
    public Sprite DownSprite;

    private void Awake()
    {
        StartCoroutine(Timer(20));
        print(PlayerPrefs.GetInt("Hallo"));
    }
    private IEnumerator Timer(float timeInSeconds)
    {
        print("timer for " + timeInSeconds);
            while (timeInSeconds != 0)
        {
            yield return new WaitForSeconds(1f);
            timeInSeconds--;
            print($"nog: {timeInSeconds} seconden");
        }
        SceneManager.LoadScene("Hub");
    }
    private void Start()
    {
        spriteRenderer.sprite = UpSprite;
    }
    void Update()
    {
        //timer om te zien hoelang de slow duurt bij level 2
        if (timer > 0f)
        {
            timer -= Time.deltaTime;
        }

        if (timer == 0 || timer < 0f)
        {
            Invoke("Reset", 0f); //dit roeps de reset functie aan die ervoor zorgt dat de speed van de player weer terug naar de oude gaat.
        }

        //voor
        if (Input.GetKey("w"))
        {

            rb.velocity = new Vector3(0, speed, 0);
            spriteRenderer.sprite = UpSprite;
        }
        //rechts
        if (Input.GetKey("a"))
        {
            rb.velocity = new Vector3(-speed, 0, 0);
            spriteRenderer.sprite = LSprite;
        }
        //achter
        if (Input.GetKey("s"))
        {
            rb.velocity = new Vector3(0, -speed, 0);
            spriteRenderer.sprite = DownSprite;
        }
        //links
        if (Input.GetKey("d"))
        {
            rb.velocity = new Vector3(speed, 0, 0);
            spriteRenderer.sprite = RSprite;
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




    private void OnCollisionEnter2D(Collision2D collisionInfo)
    {
        if (collisionInfo.collider.tag == "Wall")
        {
            rb.velocity = new Vector3(0, 0, 0);
        }




        //als je door een slow trap geraakt word bij level 2.
        else if (collisionInfo.collider.tag == "Slowtrap")
        {
            //Debug.Log("De slow werkt");
            speed = 2;
            timer += 5;


            SlowIcon.SetActive(true);
        }
    }
    void Reset()
    {
        SlowIcon.SetActive(false);
        speed = 3;
    }
}

