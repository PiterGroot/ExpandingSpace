using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class InventoryManager : MonoBehaviour
{

    public List<string> items = new List<string>();
    //items
    public GameObject HealSprite;
    public Sprite ShieldSprite;
    public Sprite ShotgunSprite;
    public Sprite SpeedSprite;
    public Sprite FirerateSprite;

    //what did i buy?
    public string Heal;
    public string Shield;
    public string Shotgun;
    public string Speed;
    public string Firerate;
    //slots
    public Image Itemslot1;
    public Image Itemslot2;
    public Image Itemslot3;
    void Start()
    {
     
        PlayerPrefs.SetString("HealUpgrade", "yes");
        PlayerPrefs.SetString("ShieldUpgrade", "yes");
        PlayerPrefs.SetString("SpeedUpgrade", "yes");
        Heal = PlayerPrefs.GetString("HealUpgrade");
        Shield = PlayerPrefs.GetString("ShieldUpgrade");
        Shotgun = PlayerPrefs.GetString("ShotgunUpgrade");
        Speed = PlayerPrefs.GetString("SpeedUpgrade");
        Firerate = PlayerPrefs.GetString("FirerateUpgrade");
        MakeList();
        Slot1();
        Slot2();
        Slot3();
    }
    void MakeList()
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
    }
    public void Slot1()
    {
       // Debug.Log("slot 1 wrkt");
        switch (items[0])
        {
            case "Heal":
                // qDebug.Log("het is HEal");
                Instantiate(HealSprite, new Vector2(Itemslot1.transform.position.x,Itemslot1.transform.position.y), Quaternion.identity);
                // Itemslot1.sprite = HealSprite;
                break;
            case "Shield":
                Itemslot1.sprite = ShieldSprite;
                break;
            case "Speed":
                Itemslot1.sprite = SpeedSprite;
                break;
            case "Firerate":
                Itemslot1.sprite = FirerateSprite;
                break;
            case "Shotgun":
                Itemslot1.sprite = ShotgunSprite;
                break;

        }
    }
    public void Slot2()
    {
       // Debug.Log("slot 2 wrkt");
        switch (items[1])
        {
            case "Heal":
                // qDebug.Log("het is HEal");
                //Itemslot2.sprite = HealSprite;
                break;
            case "Shield":
                Itemslot2.sprite = ShieldSprite;
                break;
            case "Speed":
                Itemslot2.sprite = SpeedSprite;
                break;
            case "Firerate":
                Itemslot2.sprite = FirerateSprite;
                break;
            case "Shotgun":
                Itemslot2.sprite = ShotgunSprite;
                break;

        }
    }
    public void Slot3()
    {
        //Debug.Log("slot 3 wrkt");
        switch (items[2])
        {
            case "Heal":
                // qDebug.Log("het is HEal");
                //Itemslot3.sprite = HealSprite;
                break;
            case "Shield":
                Itemslot3.sprite = ShieldSprite;
                break;
            case "Speed":
                Itemslot3.sprite = SpeedSprite;
                break;
            case "Firerate":
                Itemslot3.sprite = FirerateSprite;
                break;
            case "Shotgun":
                Itemslot3.sprite = ShotgunSprite;
                break;

        }
    }
}

