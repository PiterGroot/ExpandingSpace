using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shotgunShoot : MonoBehaviour
{
    private Boss BossScript;
    [SerializeField] private bool canShootOverride;
    [SerializeField] private int fpsLimiter;
    [SerializeField] public bool canShoot;
    [SerializeField] private bool godMode;
    public GameObject Bullet;
    public int ShootTimer;
    public Shooting shooting;
    [HideInInspector] public int shootTimerMax;


   
    void Update()
    {
        ShootTimer = shooting.ShootTimer;
        if (!godMode && canShoot)
        {
          

            if (ShootTimer <= 1 && Input.GetKey("space"))
            {
                
                ShootTimer = shootTimerMax;
                FindObjectOfType<AudioManager>().Play("Laser");
                Instantiate(Bullet, transform.position + new Vector3(1.2f, -.2f), Quaternion.identity);
            }
        }
        else if (canShootOverride)
        {
         

            if (ShootTimer <= 1 && Input.GetKey("space"))
            {
           
                ShootTimer = shootTimerMax;
                FindObjectOfType<AudioManager>().Play("Laser");
                Instantiate(Bullet, transform.position + new Vector3(1.2f, -.2f), Quaternion.identity);
            }
        }
        else if (godMode && canShoot)
        {
          
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
