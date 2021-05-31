using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class Questcheck : MonoBehaviour
{
    private quetsUpdate questupdate;
    public TextMeshProUGUI questtodo;
    
    public int score;

    void Awake()
    {
        questupdate = GameObject.FindObjectOfType<quetsUpdate>();
        score = PlayerPrefs.GetInt("punten");
        questtodo.text ="Tasks:\n " + score.ToString() + "/3";


    }


   
}
