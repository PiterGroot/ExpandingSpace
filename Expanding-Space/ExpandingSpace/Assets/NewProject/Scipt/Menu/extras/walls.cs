using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class walls : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {

       
        if (collision.collider.name== "meteor")
        {
             collision.gameObject.GetComponent<floatingMeteor>().randSide();
        }
        else
        {
            collision.gameObject.GetComponent<floatingMeteor>().randSide();
        }
    }
    public void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.collider.name == "meteor")
        {
            collision.gameObject.GetComponent<floatingMeteor>().randSide();
        }
        else
        {
            collision.gameObject.GetComponent<floatingMeteor>().randSide();
        }
    }

}
