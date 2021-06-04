using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bush : MonoBehaviour
{
    public static float Health;

   // Start is called before the first frame update
    void Start()
    {
        Health = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (Health == 0)
        {
            Destroy(this.gameObject);
        }
    }



}
