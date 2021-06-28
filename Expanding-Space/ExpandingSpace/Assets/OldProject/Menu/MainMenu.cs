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
    public Image bgws;
    public Image bgad;
    public void SceneSwitch(string SceneName)
    {

        PlayerPrefs.DeleteAll();
        //PlayerPrefs.SetInt("punten", 0);
        //PlayerPrefs.SetInt("lvl1Done", 0);
        SceneManager.LoadScene(SceneName);
    }

    public void play(){
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

    public void ws()
    {
        bgws.sprite = bgselected ;
    }
    public void ad()
    {
        bgad.sprite = bgselected;
    }
    public void Exit()
    {
        Application.Quit();

    }
}
