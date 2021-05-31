using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Score : MonoBehaviour
{
    public TextMeshProUGUI Balscore;
    public TextMeshProUGUI Stickscore;
    public int scoreB;
    public int scoreS;
    private void Update()
    {
        Balscore.text = scoreB.ToString();
        Stickscore.text = scoreS.ToString();
        Debug.Log("Score B:"+scoreB); 
        Debug.Log("Score S: "+scoreS);
    }


}
