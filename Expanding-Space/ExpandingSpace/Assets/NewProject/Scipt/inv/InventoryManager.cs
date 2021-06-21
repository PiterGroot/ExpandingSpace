using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class InventoryManager : MonoBehaviour
{

    public List<string> items = new List<string>();
    //items
    public GameObject HealSprite;
    public GameObject ShieldSprite;
    public Sprite ShotgunSprite;
    public Sprite SpeedSprite;
    public GameObject FirerateSprite;

    //what did i buy?
    /*
    public string Heal;
    public string Shield;
    public string Shotgun;
    public string Speed;
    public string Firerate;
    */

    public bool Heal;
    public bool Shield;
    public bool VerspreidShot;
    public bool Speed;
    public bool Firerate;
    //slots
    public Image Itemslot1;
    public Image Itemslot2;
    public Image Itemslot3;
    public GameObject hub;

    public RandomText RandomText;
    private void Update()
    {
       // Heal = RandomText.Heal;
       // Shield = RandomText.Shield;
        //VerspreidShot = RandomText.VerspreidShot;
        //Speed = RandomText.Speed;
        //Firerate = RandomText.Firerate;
        //Slot1();
        //Slot2();
        //Slot3();
        MakeList();


    }



    void InvStart()
    {  
        /*
        Heal = 
        Shield = PlayerPrefs.GetString("ShieldUpgrade");
        Shotgun = PlayerPrefs.GetString("ShotgunUpgrade");
        Speed = PlayerPrefs.GetString("SpeedUpgrade");
        Firerate = PlayerPrefs.GetString("FirerateUpgrade");
        */

     
       
    }
    /* void MakeList()
    {
        if (Heal == "yes")
        {
            items.Add("Heal");
        }
        if (Shield == "yes")
        {
            items.Add("Shield");
        }
        if (Shotgun == "yes")
        {
            items.Add("Shotgun");
        }
        if (Speed == "yes")
        {
            items.Add("Speed");
        }
        if (Firerate == "yes")
        {
            items.Add("Firerate");
        }
      }*/

    void MakeList()
    {
        if (Heal == true)
        {
            items.Add("Heal");
        }
        if (Shield == true)
        {
            items.Add("Shield");
        }
        if (VerspreidShot == true)
        {
            items.Add("Shotgun");
        }
        if (Speed == true)
        {
            items.Add("Speed");
        }
        if (Firerate == true)
        {
            items.Add("Firerate");
        }
    }

    //add functies
    public void ReparerenGk()
    {
        Debug.Log("Heal gekocht!");
        Heal = true;
        MakeList();
        //PlayerPrefs.SetString("HealUpgrade", "yes");
    }
    public void ShieldGk()
    {
        Debug.Log("Shield gekocht!");
        Shield = true;
        MakeList();
        //  PlayerPrefs.SetString("ShieldUpgrade", "yes");
    }
    public void VerspreidShotGk()
    {
        Debug.Log("Verspreid gekocht!");
        VerspreidShot = true;
        MakeList();
        //  PlayerPrefs.SetString("ShotgunUpgrade", "yes");
    }
    public void FirerateGk()
    {
        Debug.Log("Firerate gekocht!");
        Firerate = true;
        MakeList();
        //PlayerPrefs.SetString("FirerateUpgrade", "yes");
    }
   public void SpeedGk()
    {
        Debug.Log("speed gekocht!");
        Speed = true;
        MakeList();
        // PlayerPrefs.SetString("SpeedUpgrade", "yes");
        // return PlayerPrefs.GetString("SpeedUpgrade");
    }
   





    public void Slot1()
    {
        Debug.Log("slot 1 wrkt");
        switch (items[0])
        {
            case "Heal":
                Instantiate(HealSprite, new Vector3(Itemslot1.transform.position.x, Itemslot1.transform.position.y, Itemslot1.transform.position.z), Quaternion.identity);
           
                break;
            case "Shield":
                Instantiate(ShieldSprite, new Vector3(Itemslot1.transform.position.x, Itemslot1.transform.position.y,Itemslot1.transform.position.z), Quaternion.identity);
                break;
            case "Speed":
                Itemslot1.sprite = SpeedSprite;
                break;
            case "Firerate":
                Instantiate(FirerateSprite, new Vector3(Itemslot1.transform.position.x, Itemslot1.transform.position.y,Itemslot1.transform.position.z), Quaternion.identity);
                break;
            case "Shotgun":
                Itemslot1.sprite = ShotgunSprite;
                break;

        }
    }
    public void Slot2()
    {
        Debug.Log("slot 2 wrkt");
        switch (items[1])
        {
            case "Heal":
                Instantiate(HealSprite, new Vector3(Itemslot2.transform.position.x, Itemslot2.transform.position.y, Itemslot2.transform.position.z), Quaternion.identity);

                break;
            case "Shield":
                Instantiate(ShieldSprite, new Vector3(Itemslot2.transform.position.x, Itemslot2.transform.position.y, Itemslot2.transform.position.z), Quaternion.identity);
                break;
            case "Speed":
                Itemslot2.sprite = SpeedSprite;
                break;
            case "Firerate":
                Instantiate(FirerateSprite, new Vector3(Itemslot2.transform.position.x, Itemslot2.transform.position.y, Itemslot2.transform.position.z), Quaternion.identity);
                break;
            case "Shotgun":
                Itemslot2.sprite = ShotgunSprite;
                break;

        }
    }
    public void Slot3()
    {
        Debug.Log("slot 3 wrkt");
        switch (items[2])
        {
            case "Heal":
                Instantiate(HealSprite, new Vector3(Itemslot3.transform.position.x, Itemslot3.transform.position.y, Itemslot3.transform.position.z), Quaternion.identity);
                break;
            case "Shield":
                Instantiate(ShieldSprite, new Vector3(Itemslot3.transform.position.x, Itemslot3.transform.position.y, Itemslot3.transform.position.z), Quaternion.identity);
                break;
            case "Speed":
                Itemslot3.sprite = SpeedSprite;
                break;
            case "Firerate":
                Instantiate(FirerateSprite, new Vector3(Itemslot3.transform.position.x, Itemslot3.transform.position.y, Itemslot3.transform.position.z), Quaternion.identity);
                break;
            case "Shotgun":
                Itemslot3.sprite = ShotgunSprite;
                break;

        }
    }
}

