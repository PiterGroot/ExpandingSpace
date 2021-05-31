using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Thieff : MonoBehaviour
{
    public float TimeBetweenNumber;
    public float speed;
    private Vector2 moveDir;
    public float timer = 0;
    public GameObject SlowIcon;
    int randomNumber;
    int oldNumber;
    public Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        TimeBetweenNumber = 500;
        oldNumber = 0;
        moveDir = Vector2.right;
    }

    // Update is called once per frame
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

        if (TimeBetweenNumber > 0)
        {
            TimeBetweenNumber -= 1;
        }

        //Walking
        if (TimeBetweenNumber == 0)
        {
            randomNumber = RandomNum();
            TimeBetweenNumber = 500;
            if(oldNumber == randomNumber)
            {
                TimeBetweenNumber = 0;
            }
            else
            {
                switch (randomNumber)
                {
                    case 1:
                        moveDir = Vector2.left;
                        oldNumber = 1;
                        return;
                    case 2:
                        moveDir = Vector2.right;
                        oldNumber = 2;
                        return;
                    case 3:
                        moveDir = Vector2.up;
                        oldNumber = 3;
                        return;
                    case 4:
                        moveDir = Vector2.down;
                        oldNumber = 4;
                        return;
                }
            }
        }

        rb.velocity = moveDir * speed;
        

    }
    int RandomNum()
    {
        int Number = Random.Range(1, 5);
        return Number;
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Wall")
        { 
            TimeBetweenNumber = 0;

        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
         if (collision.collider.tag == "Slowtrap")
        {
            //Debug.Log("De slow werkt");
            speed = 3;
            timer += 5;


            SlowIcon.SetActive(true);
        }
    }
    void Reset()
    {
        SlowIcon.SetActive(false);
        speed = 5;
    }
}
