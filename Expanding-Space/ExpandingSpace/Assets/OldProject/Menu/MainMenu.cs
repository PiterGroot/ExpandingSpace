using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public GameObject Options;
    public GameObject Mainmenu;
    public GameObject controles;
    public Sprite bgselected;
    public GameObject WS;
    public GameObject bgad;
    



    public void Start()
    {
        PlayerPrefs.GetInt("firestRun" + 1);
        if (PlayerPrefs.GetInt("firstRun") >= 1)
        {
            PlayerPrefs.SetString("Controles", "ad");
        }
    }
    public void SceneSwitch(string SceneName)
    {
        PlayerPrefs.DeleteKey("Wallet");
        PlayerPrefs.DeleteKey("Demo");
        PlayerPrefs.DeleteKey("EersteUitleg");

        SceneManager.LoadScene(SceneName);
    }
    public void start()
    {
        PlayerPrefs.SetInt("firstRun", 0);
        controles.SetActive(true);
        Mainmenu.SetActive(false);
    }
    public void Opties()
    {
        Mainmenu.SetActive(false);
        Options.SetActive(true);
    }
    public void Back()
    {
        Options.SetActive(false);
        controles.SetActive(false);
        Mainmenu.SetActive(true);
    }

    public void options()
    {
        controles.SetActive(true);
        Mainmenu.SetActive(false);
    }

    public void controlesws()
    {
        PlayerPrefs.SetString("Controles", "ws");
        print(PlayerPrefs.GetString("Controles"));
    }


    public void controllesad()
    {

        PlayerPrefs.SetString("Controles", "ad");
        Debug.Log(PlayerPrefs.GetString("Controles"));
    }
    public void Exit()
    {
        PlayerPrefs.DeleteAll();
        Application.Quit();

    }
}
