using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pickup : MonoBehaviour
{
    public enum ObjectType
    {
        BAL, 
        STICK
    }
    public ObjectType type;
    public bool canGrab = false;
    private Score score;
    public GameObject text;

    void OnCollisionEnter2D(Collision2D collisionInfo)
    {
        if (collisionInfo.collider.tag == "Player")
        {
            text.SetActive(true);
            canGrab = true;
        }

    }
    private void Start()
    {
        //DOE AAN WANNEER SCORE OF ITEM HOEVEELHEID WORD GEDAAN.
        // score = GameObject.Find("player").GetComponent<Score>();
    }

    void Update()
    {
        if (canGrab == true && Input.GetKey("e"))
        {
            //swtich om te checken welk object het is.

            //DOE AAN WANNEER SCORE OF ITEM HOEVEELHEID WORD GEDAAN.
            //switch (type)
            //{
            //    case ObjectType.BAL:
            //        score.scoreB++;
            //        break;
            //    case ObjectType.STICK:
            //        score.scoreS++;
            //        break;
            //    default:
            //        break;
          //  }
          
            Destroy(gameObject);
            

        }

    }
    private void OnCollisionExit2D(Collision2D collision)
    {

        text.SetActive(false);
        canGrab = false;
    }
}
