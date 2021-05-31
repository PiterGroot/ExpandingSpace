using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trapspawns : MonoBehaviour
{
    public GameObject prefabslow;
    public int Slowtraps;
    Vector2 Cor(float x, float y)
    {
         x = Random.Range(-20.0f, 10.0f);
         y = Random.Range(10.0f, -10.0f);
        return new Vector2(x, y);
       
        
    }

    private void Start()
    {

        int traps = 0;
        while (traps < Slowtraps)
        {
            GameObject trap = Instantiate(prefabslow, new Vector2(Random.Range(-22.0f, 9.0f), Random.Range(7.0f, -5.0f)), prefabslow.transform.rotation);
            traps++;
        }
    }
}
