using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//import text mesh pro
using TMPro;

public class DropDown : MonoBehaviour
{
    public GameObject Button1;
    public GameObject Button2;
    public TextMeshProUGUI selected;
    private bool MenuOpen = false;
    public string Selected ="Normal";
    


    private void Start()
    {
        
    }

    public void DropDOwnOpenen()
    {

        if (MenuOpen == false)
        {
            MenuOpen = true;
            Button1.SetActive(true);
            Button2.SetActive(true);
            selected.text = "Opties";
        }
        else if (MenuOpen == true)
        {
            MenuOpen = false;
            Button1.SetActive(false);
            Button2.SetActive(false);
            selected.text = Selected;
        }

    }
    public void Normal()
    {
        MenuOpen = false;
        Button1.SetActive(false);
        Button2.SetActive(false);
        Selected = "Normal";
        selected.text = Selected;
        PlayerPrefs.SetFloat("DialogueSpeed", 0.05f);
        Debug.Log(PlayerPrefs.GetFloat("DialogueSpeed"));
    }
    public void Fast()
    {
        

        PlayerPrefs.SetFloat("DialogueSpeed", 0.05f);
        MenuOpen = false;
        Button1.SetActive(false);
        Button2.SetActive(false);
        Selected = "Fast ";
        selected.text = Selected;
        PlayerPrefs.SetFloat("DialogueSpeed",PlayerPrefs.GetFloat("DialogueSpeed") -0.02f);
        Debug.Log(PlayerPrefs.GetFloat("DialogueSpeed"));
    }
}
