using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpManager : MonoBehaviour
{
    public InventoryManager inventoryManager;
    public GameObject shieldborder;
    public GameObject Shieldlife1;
    public GameObject Shieldlife2;
    public GameObject Shieldlife3;
    public CollisionManager collisionManager;

    public GameObject shotgunpart1;
    public GameObject shotgunpart2;

    public SpaceShip SpaceshipSpeed;
    public bool firerate=false;

    private void Start()
    {
       
       
    }
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            slot1Activate();
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            slot2Activate();
        }
    }

    public void slot1Activate()
    {
        switch (inventoryManager.items[0])
        {
            case "Heal":
                if (collisionManager.Health == 3)
                {
                    Debug.Log("Hp is vol");
                }
                else if(collisionManager.Health<3)
                {
                    Debug.Log("add hp");
                    inventoryManager.slotused1 = true;                                              //het slot is gebruikt!.
                    collisionManager.Health +=1;                                                    //telt hp op bij de collision manager script 

                    inventoryManager.items.RemoveAt(0);                                         //dit stuk reset de slot en haalt het item weg na gebruik.
                    Destroy(inventoryManager.Itemslot1.transform.GetChild(0).gameObject);
                }
                break;
            case "Shield":
                shieldborder.SetActive(true);
                collisionManager.shield=3;

                inventoryManager.items.RemoveAt(0);
                Destroy(inventoryManager.Itemslot1.transform.GetChild(0).gameObject);
                break;
            case "Speed":
                SpaceshipSpeed.speed = 7;
                Debug.Log("Speed is active");

                inventoryManager.items.RemoveAt(0);
                Destroy(inventoryManager.Itemslot1.transform.GetChild(0).gameObject);
                break;
            case "Firerate":
                Debug.Log("Firerate is active");
                firerate = true;
                inventoryManager.items.RemoveAt(0);
                Destroy(inventoryManager.Itemslot1.transform.GetChild(0).gameObject);
                break;
            case "Shotgun":
                Debug.Log("Shotgun is active");
                shotgunpart1.SetActive(true);
                shotgunpart2.SetActive(true);
                inventoryManager.items.RemoveAt(0);
                Destroy(inventoryManager.Itemslot1.transform.GetChild(0).gameObject);
                break;

        }
    }

    public void slot2Activate()
    {
        switch (inventoryManager.items[1])
        {
            case "Heal":
                if (collisionManager.Health == 3)
                {
                    Debug.Log("Hp is vol");
                }
                else if (collisionManager.Health < 3)
                {
                    Debug.Log("add hp");
                    inventoryManager.slotused1 = true;                                              //het slot is gebruikt!.
                    collisionManager.Health += 1;                                                    //telt hp op bij de collision manager script 

                    inventoryManager.items.RemoveAt(1);                                         //dit stuk reset de slot en haalt het item weg na gebruik.
                    Destroy(inventoryManager.Itemslot2.transform.GetChild(0).gameObject);
                }
                break;
            case "Shield":
                shieldborder.SetActive(true);
                collisionManager.shield = 3;

                inventoryManager.items.RemoveAt(1);
                Destroy(inventoryManager.Itemslot2.transform.GetChild(0).gameObject);
                break;
            case "Speed":
                SpaceshipSpeed.speed = 7;
                Debug.Log("Speed is active");

                inventoryManager.items.RemoveAt(1);
                Destroy(inventoryManager.Itemslot2.transform.GetChild(0).gameObject);
                break;
            case "Firerate":
                Debug.Log("Firerate is active");
                firerate = true;
                inventoryManager.items.RemoveAt(1);
                Destroy(inventoryManager.Itemslot2.transform.GetChild(0).gameObject);
                break;
            case "Shotgun":
                Debug.Log("Shotgun is active");
                shotgunpart1.SetActive(true);
                shotgunpart2.SetActive(true);
                inventoryManager.items.RemoveAt(1);
                Destroy(inventoryManager.Itemslot2.transform.GetChild(0).gameObject);
                break;

        }
    }




}






























