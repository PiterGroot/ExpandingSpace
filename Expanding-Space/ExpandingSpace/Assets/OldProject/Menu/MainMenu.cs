using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject Options;
    public GameObject Mainmenu;
    public void SceneSwitch(string SceneName)
    {
        Debug.Log("werk");
        PlayerPrefs.DeleteAll();
        //PlayerPrefs.SetInt("punten", 0);
        //PlayerPrefs.SetInt("lvl1Done", 0);
        SceneManager.LoadScene(SceneName); 
    }
    public void Opties()
    {
        Mainmenu.SetActive(false);
        Options.SetActive(true);
    }
    public void Back()
    { 
        Options.SetActive(false);
        Mainmenu.SetActive(true);
    }
    public void Exit()
    {
        Application.Quit();

    }
}
