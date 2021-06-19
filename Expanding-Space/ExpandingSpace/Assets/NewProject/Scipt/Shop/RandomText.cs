using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class RandomText : MonoBehaviour
{
    public bool Heal;
    public bool Shield;
    public bool VerspreidShot;
    public bool Speed;
    public bool Firerate;

    int NumberOftext;
    public Text TextChanger;
    public Button Button;
    public Button KoopButton;
    public TextMeshProUGUI Beschrijving;
    public TextMeshProUGUI NaamProduct;
    public TextMeshProUGUI Prijs;
    public InventoryManager InvManager;

    // Start is called before the first frame update
    void Start()
    {
        //string BoughtSpeed = invManager.SpeedGk();
    }

    // Update is called once per framehgj
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
                TextChanger.text = "Verspreid Schot";
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
        NaamProduct.text = "Snelheid'";
        Beschrijving.text = "Je snelheid van je schip gaat omhoog";
        Prijs.text = "5";
      //  KoopButton.onClick.AddListener();
    }

    void ButtonHealth()
    {
        NaamProduct.text = "Repareren";
        Beschrijving.text = "Je repareert het schip en het krijgt er 1 hartje ervoor terug";
        Prijs.text = "15";
    }

    void ButtonShield()
    {
        NaamProduct.text = "Schild";
        Beschrijving.text = "Je krijgt voor 30 seconden een schild hierdoor kan je niet geraakt worden";
        Prijs.text = "30";
    }

    void ButtonFirerate()
    {
        NaamProduct.text = "Vuur Snelheid";
        Beschrijving.text = "Je kan voor 30 seconde sneller schieten";
        Prijs.text = "20";
    }

    void ButtonShotgun()
    {
        NaamProduct.text = "Verspreid Schot";
        Beschrijving.text = "Je schot wordt verdubbelt naar 3 ";
        Prijs.text = "50";

    }


    public void buy()
    {
      
        if (NaamProduct.text == "Vuur Snelheid")
        {
            InvManager.SpeedGk();
        }
        else if (NaamProduct.text == "Verspreid Schot")
        {
            InvManager.VerspreidShotGk();
        } 
        else if(NaamProduct.text== "Shild")
        {
            InvManager.ShieldGk();
        }
        else if(NaamProduct.text == "Repareren")
        {
            InvManager.ReparerenGk();
        }
        else if(NaamProduct.text== "Snelheid")
        {
            InvManager.SpeedGk();
        }
    }
}
