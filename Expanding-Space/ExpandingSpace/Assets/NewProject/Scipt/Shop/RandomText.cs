using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RandomText : MonoBehaviour
{
    int NumberOftext;
    public Text TextChanger;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        switch (NumberOftext)
        {
            case 1:
                TextChanger.text = "Snelheid";
                break;
            case 2:
                TextChanger.text = "Repareren";
                break;
            case 3:
                TextChanger.text = "Schild";
                break;
            case 4:
                TextChanger.text = "Vuur Snelheid";
                break;
            case 5:
                TextChanger.text = "Meer Pew Pew";
                break;
        }
    }

    public int ActivedSpeed()
    {
        NumberOftext = 1;
        return NumberOftext;
    }
    public int ActivedHealth()
    {
        NumberOftext = 2;
        return NumberOftext;
    }
    public int ActivedShield()
    {
        NumberOftext = 3;
        return NumberOftext;
    }
    public int ActivedFireRate()
    {
        NumberOftext = 4;
        return NumberOftext;
    }
    public int ActivedShotgun()
    {
        NumberOftext = 5;
        return NumberOftext;
    }
}
