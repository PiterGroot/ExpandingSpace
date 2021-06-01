using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class quetsUpdate : MonoBehaviour
{ 
    public int questv;
  
           
           
    
    void OnCollisionEnter2D(Collision2D collisionInfo)
    {
        if (collisionInfo.collider.tag == "Player" && PlayerPrefs.GetInt("lvl1Done")== 0)
        {
            PlayerPrefs.SetInt("lvl1Done", 1);
            PlayerPrefs.SetInt("quest1",PlayerPrefs.GetInt("quest1")+1);
            SceneManager.LoadScene("Hub");

        }
        else if (collisionInfo.collider.tag == "Player" && PlayerPrefs.GetInt("lvl1Done") == 1)
        { 
            SceneManager.LoadScene("Hub");

        }

    }
}
