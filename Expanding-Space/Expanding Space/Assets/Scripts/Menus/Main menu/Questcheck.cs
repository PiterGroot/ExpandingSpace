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
    
    public int scoreq1;
    public int scoreq2;
    public GameObject q1Kruis;
    public GameObject q1check;
    public GameObject q2kruis;
    public GameObject q2check;

    void Awake()
    {
        questupdate = GameObject.FindObjectOfType<quetsUpdate>();
        scoreq1 = PlayerPrefs.GetInt("quest1");

        if (scoreq1 == 1)
        {
            q1Kruis.SetActive(false);
            q1check.SetActive(true);
        }

        else if(scoreq2 == 1)
        {
            q2kruis.SetActive(false);
            q2check.SetActive(true);
        }
        //questtodo.text ="Tasks:\n " + score.ToString() + "/3";


    }


   
}
