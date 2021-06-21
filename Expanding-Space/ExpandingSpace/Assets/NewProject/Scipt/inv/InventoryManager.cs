using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class InventoryManager : MonoBehaviour
{
    //items
    public GameObject HealSprite;
    public GameObject ShieldSprite;
    public Sprite ShotgunSprite;
    public Sprite SpeedSprite;
    public GameObject FirerateSprite;

    //bools to check the itemslots
    public bool Slot1Free;
    public bool Slot2Free;
    public bool Slot3Free;

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

    public RandomText RandomText;

    private void Start()
    {
        Slot1Free = true;
        Slot2Free = true;
        Slot3Free = true;
    }
    private void Update()
    {
        MakeList();
    } 

    void MakeList()
    {
        if(Slot1Free == true)
        {
            if (Heal == true)
            {
                Slot1Free = false;
            }
            if (Shield == true)
            {
                Slot1Free = false;
            }
            if (VerspreidShot == true)
            {
                Slot1Free = false;
            }
            if (Speed == true)
            {
                Slot1Free = false;
            }
            if (Firerate == true)
            {
                Slot1Free = false;
            }
        }
        else if (Slot2Free == true)
        {
            if (Heal == true)
            {
                Slot2Free = false;
            }
            if (Shield == true)
            {
                Slot2Free = false;
            }
            if (VerspreidShot == true)
            {
                Slot2Free = false;
            }
            if (Speed == true)
            {
                Slot2Free = false;
            }
            if (Firerate == true)
            {
                Slot2Free = false;
            }
        }
        else if (Slot3Free == true)
        {
            if (Heal == true)
            {
                Slot3Free = false;
            }
            if (Shield == true)
            {
                Slot3Free = false;
            }
            if (VerspreidShot == true)
            {
                Slot3Free = false;
            }
            if (Speed == true)
            {
                Slot3Free = false;
            }
            if (Firerate == true)
            {
                Slot3Free = false;
            }
        }


    }

    //add functies
    public void ReparerenGk()
    {
        Debug.Log("Heal gekocht!");
        Heal = true;
        MakeList();
    }
    public void ShieldGk()
    {
        Debug.Log("Shield gekocht!");
        Shield = true;
        MakeList();
    }
    public void VerspreidShotGk()
    {
        Debug.Log("Verspreid gekocht!");
        VerspreidShot = true;
        MakeList();
    }
    public void FirerateGk()
    {
        Debug.Log("Firerate gekocht!");
        Firerate = true;
        MakeList();
    }
   public void SpeedGk()
    {
        Debug.Log("speed gekocht!");
        Speed = true;
        MakeList();
    }
   

    
}

