using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RandomText : MonoBehaviour
{
    int NumberOftext;
    public Text TextChanger;
    public Button Button; 

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
                Button.onClick.AddListener(ButtonSpeed);
                break;
            case 2:
                TextChanger.text = "Repareren";
                Button.onClick.AddListener(ButtonHealth);
                break;
            case 3:
                TextChanger.text = "Schild";
                Button.onClick.AddListener(ButtonShield);
                break;
            case 4:
                TextChanger.text = "Vuur Snelheid";
                Button.onClick.AddListener(ButtonFirerate);
                break;
            case 5:
                TextChanger.text = "Meer Pew Pew";
                Button.onClick.AddListener(ButtonShotgun);
                break;
        }
    }

    //Change text
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

    //Button action

    void ButtonSpeed()
    {
        Debug.Log("Test Speed");
    }

    void ButtonHealth()
    {
        Debug.Log("Test Health");
    }

    void ButtonShield()
    {
        Debug.Log("Test Shield");
    }

    void ButtonFirerate()
    {
        Debug.Log("Test Firerate");
    }

    void ButtonShotgun()
    {
        Debug.Log("Test Shotgun");
    }


}
