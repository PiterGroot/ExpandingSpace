using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlowTrap : MonoBehaviour
{

    void OnCollisionEnter2D(Collision2D collisionInfo)
    {
        if (collisionInfo.collider.tag == "Player")
        {
            Destroy(gameObject);
        }
        else if (collisionInfo.collider.tag == "Snail")
        {
            Destroy(gameObject);
        }
    }
}
