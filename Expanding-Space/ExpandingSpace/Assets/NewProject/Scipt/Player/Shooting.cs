using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    [SerializeField] private bool godMode;
    public GameObject Bullet;
    public int ShootTimer;
    [HideInInspector]public int shootTimerMax;
    private void Awake(){
        shootTimerMax = ShootTimer;
    }

    // Update is called once per frame
    void Update()
    {
        if (!godMode)
        {
            ShootTimer -= 1;

            if (ShootTimer <= 0 && Input.GetKey("space"))
            {
                ShootTimer = shootTimerMax;
                FindObjectOfType<AudioManager>().Play("Laser");
                Instantiate(Bullet, transform.position + new Vector3(1.2f, -.2f), Quaternion.identity);
            }
        }
        else
        { 
            ShootTimer -= 1;
            if (ShootTimer <= 0 && Input.GetKey("space"))
            {
                ShootTimer = 0;
                FindObjectOfType<AudioManager>().Play("Laser");
                Instantiate(Bullet, transform.position + new Vector3(1.2f, -.7f), Quaternion.identity);
                Instantiate(Bullet, transform.position + new Vector3(1.2f, .7f), Quaternion.identity);
                Instantiate(Bullet, transform.position, Quaternion.identity);
            }
        }
    }
}
