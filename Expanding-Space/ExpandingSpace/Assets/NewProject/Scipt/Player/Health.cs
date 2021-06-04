using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{

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


}
