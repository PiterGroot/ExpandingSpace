using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopTemp : MonoBehaviour
{
    public GameObject Shoptemperay;
    // Start is called before the first frame update
    void Start()
    {
        Shoptemperay.SetActive(false);
    }

    // Update is called once per frame
    public void PopUp()
    {
        Shoptemperay.SetActive(true);
    }
}
