using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pauze : MonoBehaviour
{
    public GameObject UIBattlescene;
    public GameObject Hub;
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
        if (Input.GetKeyDown(KeyCode.Escape)){
            Menu();
        }
            
        

    }

    public void Menu()
    {
        if (playGame == true)
        {
            Debug.Log("Eerste keer");
            playGame = false;
            UIBattlescene.SetActive(false);
            Opties.SetActive(false);
            PauzeMenu.SetActive(true);
            //zorgt ervoor dat de hele game stopt
            Time.timeScale = 0f;
        }
        else if (Input.GetKey(KeyCode.Escape) && playGame == false && Opt== false)
        {
            //Debug.Log("Pauze is false");
            UIBattlescene.SetActive(true);
            
            playGame = true;
            Opties.SetActive(false);
            PauzeMenu.SetActive(false);
            UIBattlescene.SetActive(true);
            //zorgt ervoor dat de hele game verder gaat
            Time.timeScale = 1f;

        }
        else if (Input.GetKey(KeyCode.Escape) && playGame == false && Opt == true)
        {
            //Debug.Log("Pauze is true");
            Opt = false;
            Opties.SetActive(false);
            PauzeMenu.SetActive(true);
            UIBattlescene.SetActive(false);
            //zorgt ervoor dat de hele game stopt
            Time.timeScale = 0f;

        }
    }
    public void Verder()
    {
        UIBattlescene.SetActive(true);
        playGame = true;
        PauzeMenu.SetActive(false);
        UIBattlescene.SetActive(true);
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
        UIBattlescene.SetActive(true);
        Time.timeScale = 1f;
        SceneManager.LoadScene(Name);
    }
}
