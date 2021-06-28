using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class pauzecontroles : MonoBehaviour
{
    public Image bg;
    public Sprite bghover;
    public Sprite bgnormal;
   
    void OnMouseOver()
    {
        bg.sprite = bghover;
    }

    void OnMouseExit()
    {
        bg.sprite = bgnormal;
    }

}
