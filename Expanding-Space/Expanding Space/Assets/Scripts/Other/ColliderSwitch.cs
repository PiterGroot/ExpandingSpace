using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderSwitch : MonoBehaviour
{
    private void Start()
    {
        if(PlayerPrefs.GetInt("ColliderState") == 1)
        {
            this.gameObject.SetActive(false);
        }
    }

    [ContextMenu("ClearPlayerPref")]
    public void ClearPlayerPref()
    {
        PlayerPrefs.DeleteKey("ColliderState");
        print("Cleared!");
    }
    [ContextMenu("PrintPlayerPref")]
    public void PrintPlayerPref()
    { 
        print($"Playerpref: {PlayerPrefs.GetInt("ColliderState")}");
    }
}
