using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public int hp;
    public int shield;

    public CollisionManager CollitionManager;
    public GameObject life3;
    public GameObject life2;
    public GameObject life1;
    public PowerUpManager powerUpManager;



    public void Start()
    {

    }

    public void Update()
    {
        hp = CollitionManager.Health;
        shield = CollitionManager.shield;

        if (hp == 2)
        {
            life3.SetActive(false);
            life2.SetActive(true);
            life1.SetActive(true);
        }
        else if (hp == 3)
        {
            life3.SetActive(true);
            life2.SetActive(true);
            life1.SetActive(true);
        }
        else if (hp == 1)
        {
            life3.SetActive(false);
            life2.SetActive(false);
            life1.SetActive(true);
        }
        else if (hp == 0)
        {
            life2.SetActive(false);
            life3.SetActive(false);
            life1.SetActive(false);
        }
        else if (powerUpManager.shieldborder.activeSelf == true && shield == 3)
        {
            powerUpManager.Shieldlife3.SetActive(true);
            powerUpManager.Shieldlife2.SetActive(true);
            powerUpManager.Shieldlife1.SetActive(true);
        }

        else if (powerUpManager.shieldborder.activeSelf == true && shield == 2)
        {
            powerUpManager.Shieldlife3.SetActive(false);
        }
        else if (powerUpManager.shieldborder.activeSelf == true && shield == 1)
        {
            powerUpManager.Shieldlife2.SetActive(false);
        }
        else if (powerUpManager.shieldborder.activeSelf == true && shield == 0)
        {
            powerUpManager.shieldborder.SetActive(false);
        }

    }

}
