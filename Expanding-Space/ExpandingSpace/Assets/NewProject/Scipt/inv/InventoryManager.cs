using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
public class InventoryManager : MonoBehaviour
{
    //items
    public GameObject HealSprite;
    public GameObject ShieldSprite;
    public Sprite ShotgunSprite;
    public Sprite SpeedSprite;
    public GameObject FirerateSprite;
    public List<string> items = new List<string>();
    //bools to check the items
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

    //slot checks
    public bool slotused1 = true;
    public bool slotused2 = true;
    public bool slotused3 = true;


    private void Start()
    {



    }
    private void Update()
    {


    }


    //add functies 
    public void ReparerenGk()
    {
        Debug.Log("Heal gekocht!");
        Heal = true;
        items.Add("Heal");


    }
    public void ShieldGk()
    {
        Debug.Log("Shield gekocht!");
        items.Add("Shield");
        Shield = true;



    }
    public void VerspreidShotGk()
    {
        Debug.Log("Verspreid gekocht!");
        items.Add("Shotgun");
        VerspreidShot = true;



    }
    public void FirerateGk()
    {
        Debug.Log("Firerate gekocht!");
        items.Add("Firerate");
        Firerate = true;



    }
    public void SpeedGk()
    {
        Debug.Log("speed gekocht!");
        items.Add("Speed");
        Speed = true;



    }


    //Display functions
    public void Slot1()
    {
        if (slotused1 == true)
        {
            Debug.Log("slot 1 wrkt");
            switch (items[0])
            {
                case "Heal":
                    // qDebug.Log("het is HEal");
                    Instantiate(HealSprite, new Vector2(-7.92f, -4.21f), Quaternion.identity);
                    slotused1 = false;
                    Slot2();
                    break;
                case "Shield":
                    Instantiate(ShieldSprite, new Vector2(-7.92f, -4.21f), Quaternion.identity);
                    slotused1 = false;
                    Slot2();
                    break;
                case "Speed":
                    Instantiate(SpeedSprite, new Vector2(-7.92f, -4.21f), Quaternion.identity);
                    slotused1 = false;
                    Slot2();
                    break;
                case "Firerate":
                    Instantiate(FirerateSprite, new Vector2(-7.92f, -4.21f), Quaternion.identity);
                    slotused1 = false;
                    Slot2();
                    break;
                case "Shotgun":
                    Instantiate(ShotgunSprite, new Vector2(-7.92f, -4.21f), Quaternion.identity);
                    slotused1 = false;
                    Slot2();
                    break;
            }
        }
        else
        {
            Debug.Log("Slot is used");
        }
    }
    public void Slot2()
    {
        if (slotused2 == true)
        {
            Debug.Log("slot 2 wrkt");
            switch (items[1])
            {
                case "Heal":
                    // qDebug.Log("het is HEal");
                    Instantiate(HealSprite, new Vector2(-6.48f, -4.21f), Quaternion.identity);
                    slotused2 = false;
                    Slot3();
                    break;
                case "Shield":
                    Instantiate(ShieldSprite, new Vector2(-6.48f, -4.21f), Quaternion.identity);
                    slotused2 = false;
                    Slot3();
                    break;
                case "Speed":
                    Instantiate(SpeedSprite, new Vector2(-6.48f, -4.21f), Quaternion.identity);
                    slotused2 = false;
                    Slot3();
                    break;
                case "Firerate":
                    Instantiate(FirerateSprite, new Vector2(-6.48f, -4.21f), Quaternion.identity);
                    slotused2 = false;
                    Slot3();
                    break;
                case "Shotgun":
                    Instantiate(ShotgunSprite, new Vector2(-6.48f, -4.21f), Quaternion.identity);
                    slotused2 = false;
                    Slot3();
                    break;

            }
        }
        else
        {
            Debug.Log("Slot is used");
        }
    }
    public void Slot3()
    {
        if (slotused3 == true)
        {
            Debug.Log("slot 3 wrkt");
            switch (items[2])
            {
                case "Heal":
                    // qDebug.Log("het is HEal");
                    Instantiate(HealSprite, new Vector2(-5.12f, -4.21f), Quaternion.identity);
                    slotused3 = false;
                    break;
                case "Shield":
                    Instantiate(ShieldSprite, new Vector2(-5.12f, -4.21f), Quaternion.identity);
                    slotused3 = false;
                    break;
                case "Speed":
                    Instantiate(SpeedSprite, new Vector2(-5.12f, -4.21f), Quaternion.identity);
                    slotused3 = false;
                    break;
                case "Firerate":
                    Instantiate(FirerateSprite, new Vector2(-5.12f, -4.21f), Quaternion.identity);
                    slotused3 = false;
                    break;
                case "Shotgun":
                    Instantiate(ShotgunSprite, new Vector2(-5.12f, -4.21f), Quaternion.identity);
                    slotused3 = false;
                    break;

            }
        }
        else
        {
            Debug.Log("Slot is used");
        }
    }
}


