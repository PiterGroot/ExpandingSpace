using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayerChoice : MonoBehaviour
{
    [SerializeField]private WaveSpawner waveScript;
    public void LoadHub(){
        SceneManager.LoadScene("Hub");
    }
    public void GoNextWave(){
        waveScript.waitForPlayerChoice = true;
    }
}
