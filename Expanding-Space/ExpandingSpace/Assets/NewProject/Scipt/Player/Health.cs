using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    //slider code

    /*
    public Slider slider;
    public Gradient colors;
    public Image fill;
   

    public void SetMaxHp(int Health)
    {
        slider.maxValue = Health;
        slider.value = Health;
        fill.color = colors.Evaluate(1f);
    }

    public void UpdateHealth(int Health)
    {
        slider.value = Health;
        fill.color = colors.Evaluate(slider.normalizedValue);
    }
    public void Update()
    {
        
          
        fill.color = colors.Evaluate(slider.normalizedValue);

    }
    */


    public int hp;
    public CollisionManager CollitionManager;
    public GameObject life3;
    public GameObject life2;
    public GameObject life1;



    public void Start()
    {
       
    }

    public void Update()
    {
        hp = CollitionManager.Health;

        if(hp==2)
        {
            life3.SetActive(false);
        }
        else if(hp== 1)
        {
            life2.SetActive(false);
        }
        else if(hp== 0)
        {
            life1.SetActive(false);
        }
    }

}
