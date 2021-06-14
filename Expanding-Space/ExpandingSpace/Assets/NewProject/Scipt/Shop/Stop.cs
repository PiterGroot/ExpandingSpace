using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Stop : MonoBehaviour
{
    public Button QuitButton;
    [SerializeField] private GameObject Shop;
    [SerializeField] private GameObject HubFoundation;

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
        Shop.SetActive(false);
        HubFoundation.SetActive(true);
    }
}
