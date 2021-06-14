using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class lvl1Pause : MonoBehaviour
{
    public GameObject Hub;
    public GameObject Dialogue;
    public GameObject PauzeMenu;
    public GameObject Opties;

    public static bool playGame = true;
    public bool Opt = false;

    private void Start()
    {
        PauzeMenu.SetActive(false);
        Opties.SetActive(false);
    }

    void Update()
    { 
        if (Input.GetKeyDown(KeyCode.Escape)&& Hub.activeSelf == false)
        {
            Debug.Log("hub is false");
            Dialogue.SetActive(false);
            Menu();
        }

    }

    public void Menu()
    {
        if (playGame == true)
        {
            Debug.Log("Eerste keer");
            playGame = false;
            Opties.SetActive(false);
            PauzeMenu.SetActive(true);
            //zorgt ervoor dat de hele game stopt
            Time.timeScale = 0f;
        }
        else if (Input.GetKey(KeyCode.Escape) && playGame == false && Opt== false)
        {
            Debug.Log("Pauze is false");
            playGame = true;
            Opties.SetActive(false);
            PauzeMenu.SetActive(false);
            Dialogue.SetActive(true);
            //zorgt ervoor dat de hele game verder gaat
            Time.timeScale = 1f;

        }
        else if (Input.GetKey(KeyCode.Escape) && playGame == false && Opt == true)
        {
            Opt = false;
            Debug.Log("Pauze is true");
            Opties.SetActive(false);
            PauzeMenu.SetActive(true);
            //zorgt ervoor dat de hele game stopt
            Time.timeScale = 0f;

        }
    }
    public void Verder()
    {
        Dialogue.SetActive(true);
        playGame = true;
        PauzeMenu.SetActive(false);
        //zorgt ervoor dat de hele game stopt
        Time.timeScale = 1f;
    }
    public void OptiesMenu()
    {
        Opt = true;
        PauzeMenu.SetActive(false);
        Opties.SetActive(true);
       
    }
    public void back()
    {
        Opt = false;
        PauzeMenu.SetActive(true);
        Opties.SetActive(false);
    }

    public void Stop(string Name)
    {
        Dialogue.SetActive(true);
        SceneManager.LoadScene(Name);
    }
}
