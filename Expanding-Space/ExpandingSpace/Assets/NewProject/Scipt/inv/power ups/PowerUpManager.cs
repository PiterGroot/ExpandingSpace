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

    private void Start()
    {
       
       
    }
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            slot1Activate();
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
                Debug.Log("Speed is active");

                inventoryManager.items.RemoveAt(0);
                Destroy(inventoryManager.Itemslot1.transform.GetChild(0).gameObject);
                break;
            case "Firerate":
                Debug.Log("Firerate is active");

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
    
}






























