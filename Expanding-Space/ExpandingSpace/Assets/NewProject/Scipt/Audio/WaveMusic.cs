using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveMusic : MonoBehaviour
{
    public bool enableMusic;
    private void Update() {
        if(enableMusic){
            enableMusic = false;
            stopMusic();
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        print("Start");
        Invoke("Play", 1f);
    }
    void Play(){
        FindObjectOfType<AudioManager>().Play("e");
    }
    public void playMusic()
    {
        FindObjectOfType<AudioManager>().Play("e");
    }
    public void stopMusic(){
        print("Stop the music");
        FindObjectOfType<AudioManager>().Stop("e");
    }
   public void PlayOST(){
         FindObjectOfType<AudioManager>().Play("OST");
   }
   public void Select(){
         FindObjectOfType<AudioManager>().Play("Select");
   }
}
