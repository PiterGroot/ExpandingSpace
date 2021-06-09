using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Randomizer : MonoBehaviour
{
    [SerializeField] RandomText CallFunction;
    int randomNumberItem;
    public GameObject Speed;
    public GameObject Health;
    public GameObject Shield;
    public GameObject Firerange;
    public GameObject Shotgun;
    public GameObject Hub;
   

    public int Randomized()
    {
        randomNumberItem = Random.Range(1, 6);
        return randomNumberItem;
    }

    // Start is called before the first frame update
    void Start()
    {
        Randomized();
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
                Health.SetActive(false);
                Shield.SetActive(false);
                Firerange.SetActive(false);
                Shotgun.SetActive(false);
                CallFunction.ActivedSpeed();
                break;
            case 2:
                Speed.SetActive(false);
                Health.SetActive(true); 
                Shield.SetActive(false);
                Firerange.SetActive(false);
                Shotgun.SetActive(false);
                CallFunction.ActivedHealth();
                break;
            case 3:
                Speed.SetActive(false);
                Health.SetActive(false);
                Shield.SetActive(true);
                Firerange.SetActive(false);
                Shotgun.SetActive(false);
                CallFunction.ActivedShield();
                break;
            case 4:
                Speed.SetActive(false);
                Health.SetActive(false);
                Shield.SetActive(false);
                Firerange.SetActive(true);
                Shotgun.SetActive(false);
                CallFunction.ActivedFireRate();
                break;
            case 5:
                Speed.SetActive(false);
                Health.SetActive(false);
                Shield.SetActive(false);
                Firerange.SetActive(false);
                Shotgun.SetActive(true);
                CallFunction.ActivedShotgun();
                break;
        }



    }

   
}
