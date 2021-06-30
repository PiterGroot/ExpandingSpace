using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Stop : MonoBehaviour
{
    public Button QuitButton;
    [SerializeField] private GameObject Shop;
    [SerializeField] private GameObject HubFoundation;

    public Image Itemslot1;
    public Image Itemslot2;
    public Image Itemslot3;

    public InventoryShop invshop;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        QuitButton.onClick.AddListener(Quit);
    }

    void Quit()
    {
        try
        {
            clear();
        }
        catch(Exception e)
        {

        }
        Shop.SetActive(false);
        HubFoundation.SetActive(true);
    }

    void clear()
    {
        invshop.slotused1 = true;
        invshop.slotused2 = true;
        invshop.slotused3 = true;

        Destroy(Itemslot1.transform.GetChild(0).gameObject);
        Destroy(Itemslot2.transform.GetChild(0).gameObject);
        Destroy(Itemslot3.transform.GetChild(0).gameObject);
    }
}
