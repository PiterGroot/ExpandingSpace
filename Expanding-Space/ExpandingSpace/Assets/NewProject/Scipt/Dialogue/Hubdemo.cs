using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hubdemo : MonoBehaviour
{
    [SerializeField] private TriggerDialogue DemoDia;

   

    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.GetInt("Demo") != 1)
        {
            StartCoroutine(DemoDia.ActivateDialogue());
            PlayerPrefs.SetInt("Demo", 1);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
