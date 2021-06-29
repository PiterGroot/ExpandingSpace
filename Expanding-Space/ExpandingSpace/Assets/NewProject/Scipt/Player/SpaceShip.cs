using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceShip : MonoBehaviour
{
    public bool canMove = true;
    public float speed;
    public Rigidbody2D rb;

    public string main;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (canMove)
        {

            if (PlayerPrefs.GetString("Controles") == "ws")
            {
                //up
                if (Input.GetKey("w"))
                {
                    rb.velocity = new Vector3(0, speed, 0);
                }

                //down
                if (Input.GetKey("s"))
                {
                    rb.velocity = new Vector3(0, -speed, 0);
                }

                if (Input.GetKeyUp("w"))
                {
                    rb.velocity = new Vector2(0, 0);
                }
                if (Input.GetKeyUp("s"))
                {
                    rb.velocity = new Vector2(0, 0);
                }
            }
            else if (PlayerPrefs.GetString("Controles") == "ad")
            {
                //up
                if (Input.GetKey("a"))
                {
                    rb.velocity = new Vector3(0, speed, 0);
                }

                //down
                if (Input.GetKey("d"))
                {
                    rb.velocity = new Vector3(0, -speed, 0);
                }

                if (Input.GetKeyUp("a"))
                {
                    rb.velocity = new Vector2(0, 0);
                }
                if (Input.GetKeyUp("d"))
                {
                    rb.velocity = new Vector2(0, 0);
                }
            }
        }
    }
}
