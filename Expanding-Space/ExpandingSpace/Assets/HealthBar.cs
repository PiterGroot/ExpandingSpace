using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    [SerializeField]private float Maxhealth;
    [SerializeField]private Slider slider;
    [SerializeField]Boss boss;
    // Start is called before the first frame update
    void Start()
    {
        boss = FindObjectOfType<Boss>();
        Maxhealth = boss.Health;
        slider.maxValue = Maxhealth;
        slider.value = Maxhealth;
    }

    // Update is called once per frame
    void Update()
    {
        slider.value = boss.Health;
        if(boss.Health <= 0 ){
            Destroy(gameObject);
        }
    }
}
