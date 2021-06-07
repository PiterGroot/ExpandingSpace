using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Randomizer : MonoBehaviour
{
    public static int randomNumberItem;
    public GameObject Speed;
    public GameObject Health;
    public GameObject Shield;
    public GameObject Firerange;
    public GameObject Shotgun;
    private void Awake()
    {
        randomNumberItem = Random.Range(1, 6);
    }
    // Start is called before the first frame update
    void Start()
    {
        Speed.SetActive(false);
        Health.SetActive(false);
        Shield.SetActive(false);
        Firerange.SetActive(false);
        Shotgun.SetActive(false);
        
    }

    // Update is called once per frame
    void Update()
    {
        switch (randomNumberItem)
        {
            case 1:
                Speed.SetActive(true);
                break;
            case 2:
                Health.SetActive(true);
                break;
            case 3:
                Shield.SetActive(true);
                break;
            case 4:
                Firerange.SetActive(true);
                break;
            case 5:
                Shotgun.SetActive(true);
                break;
        }

    }

   
}
