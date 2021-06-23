using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public int hp;
 

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
        

        if (powerUpManager.shieldborder.activeSelf == false && hp == 2)
        {
            Debug.Log("HP2");
            life3.SetActive(false);
            life2.SetActive(true);
            life1.SetActive(true);
        }
        else if (powerUpManager.shieldborder.activeSelf == false && hp == 3)
        {
            life3.SetActive(true);
            life2.SetActive(true);
            life1.SetActive(true);
        }
        else if (powerUpManager.shieldborder.activeSelf == false && hp == 1)
        {
            life3.SetActive(false);
            life2.SetActive(false);
            life1.SetActive(true);
        }
        else if (powerUpManager.shieldborder.activeSelf == false && hp == 0)
        {
            life2.SetActive(false);
            life3.SetActive(false);
            life1.SetActive(false);
        }
        else if (powerUpManager.shieldborder.activeSelf == true && CollitionManager.shield == 3)
        {
            Debug.Log("shield active");
            powerUpManager.Shieldlife3.SetActive(true);
            powerUpManager.Shieldlife2.SetActive(true);
            powerUpManager.Shieldlife1.SetActive(true);
        }

        else if (powerUpManager.shieldborder.activeSelf == true && CollitionManager.shield == 2)
        {
            powerUpManager.Shieldlife3.SetActive(false);
            Debug.Log("shield2");
        }
        else if (powerUpManager.shieldborder.activeSelf == true && CollitionManager.shield == 1)
        {
            Debug.Log("Shield1");
            powerUpManager.Shieldlife2.SetActive(false);
        }
        else if (powerUpManager.shieldborder.activeSelf == true && CollitionManager.shield == 0)
        {
            Debug.Log("geen shield");
            powerUpManager.shieldborder.SetActive(false);
        }

    }

}
