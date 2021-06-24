using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class floatingMeteor : MonoBehaviour
{
    public Rigidbody2D rb;
    void Start()
    {
        
        int rot = Random.Range(1, 2);

        switch (rot)
        {
            case 1:
                transform.Rotate(new Vector3(0f, 0f, 5f));
                randSide();
                break;
            case 2:
                transform.Rotate(new Vector3(0f, 0f, -5f));
                randSide(); 
                break;
        }
    }


   

    public int rand()
    {
        int side = Random.Range(1, 3);
        return side;
    }
    public int randrot()
    {
        int rot = Random.Range(1, 2);
        return rot;
    }



    public void randSide()
    {
        int push = rand();
        switch (push)
        {
            case 1:
                rb.AddForce(transform.up * 0.3f, ForceMode2D.Impulse);
                

                break;
            case 2:
                rb.AddForce(transform.right * 0.3f, ForceMode2D.Impulse);
               

                break;
            case 3:
                rb.AddForce(transform.forward * 0.3f, ForceMode2D.Impulse);
              
                break;

        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.name == "meteor")
        {
            collision.gameObject.GetComponent<floatingMeteor>().randSide();
        }
    }

}
