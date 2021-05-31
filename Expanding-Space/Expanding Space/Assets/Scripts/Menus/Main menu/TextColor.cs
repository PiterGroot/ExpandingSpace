using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextColor : MonoBehaviour
{
   public Animator Animation;

    public GameObject ob;
    public GameObject speelknop;
    public GameObject Anim;
    private void Start()
    {
      
        Component Animation= GetComponent<Animator>();
    }
    private void OnMouseOver()
    {
        //if else zodat je geen errors krijg met de triggers 
       if(ob.name == "Play")
        {
            speelknop.SetActive(false);
            Anim.SetActive(true);
            Debug.Log("play werkt");
          //  Animation.SetTrigger("PlayButton");
        }

       else if (ob.name == "Opties")
        {
            Debug.Log("Options werkt");
          Animation.SetTrigger("OptionButton");
        }
       else if (ob.name == "Stoppen")
        {
            Debug.Log("Stop werkt");
            Animation.SetTrigger("StopButton");
        }
       else if (ob.name == "back")
        {
            Debug.Log("back werkt");
            Animation.SetTrigger("Back");
        }
        
    }
    private void OnMouseExit()
    {
        if (ob.name == "Play")
        {
            speelknop.SetActive(true);
            Anim.SetActive(false);
            Debug.Log("play werkt");
            //  Animation.SetTrigger("PlayButton");
        }
    }

}
