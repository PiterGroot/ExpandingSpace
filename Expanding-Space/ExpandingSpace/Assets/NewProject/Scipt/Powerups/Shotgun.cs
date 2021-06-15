using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shotgun : MonoBehaviour
{
    //place holder als shotgun is gekocht
    public string item;
    public GameObject shothunbarel;
    public GameObject shothunbarel2;
   
    void Start()
    {
        item = "yes";
    }

  
    void Update()
    {
        if (item == "yes")
        {
            shothunbarel.SetActive(true);
            shothunbarel2.SetActive(true);
        }
    }
}