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
                    collisionManager.Health +=1;
                }
                break;
            case "Shield":
                shieldborder.SetActive(true);
                collisionManager.shield=3;
                break;
            case "Speed":
                Debug.Log("Speed is active");
                break;
            case "Firerate":
                Debug.Log("Firerate is active");
                break;
            case "Shotgun":
                Debug.Log("Shotgun is active");
                break;

        }
    }
    
}






























