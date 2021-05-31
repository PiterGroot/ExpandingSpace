using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroy : MonoBehaviour
{
    public GameObject questtracker;

    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetInt("punten", 0);
    }
}

  

