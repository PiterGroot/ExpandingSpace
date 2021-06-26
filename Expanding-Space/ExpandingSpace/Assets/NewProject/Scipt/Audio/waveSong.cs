using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class waveSong : MonoBehaviour
{ 
    // Start is called before the first frame update
    void Start()
    {
        FindObjectOfType<AudioManager>().Play("e");
    }

    // Update is called once per frame
   

    public void play()
    {

        FindObjectOfType<AudioManager>().Play("e");
    }
    public void p()
    {
        print("wave music stops");
        FindObjectOfType<AudioManager>().Stop("e");

    }
}
