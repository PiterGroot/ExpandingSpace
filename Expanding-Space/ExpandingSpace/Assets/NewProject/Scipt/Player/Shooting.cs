using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    private Boss BossScript;
    [SerializeField] private bool canShootOverride;
    [SerializeField] private WaveSpawner waveSpawner;
    [SerializeField] private int fpsLimiter;
    [SerializeField] public bool canShoot;
    [SerializeField] private bool godMode;
    public GameObject Bullet;
    public int ShootTimer;
    [HideInInspector]public int shootTimerMax;
    private void Awake(){
        BossScript = FindObjectOfType<Boss>();
        shootTimerMax = ShootTimer;
        Application.targetFrameRate = fpsLimiter;
        InvokeRepeating("CheckWaveSpawner", 0, 1f);
    }
    private void CheckWaveSpawner()
    {
        if (waveSpawner.isInWave)
        {
            canShoot = true;
        }
        else
        {
            canShoot = false;
        }
    }
    public void Timer()
    {
        canShoot = false;
        Invoke("EnableShooting", 14f);
    }
    void EnableShooting(){
        canShootOverride = true;
    }
    // Update is called once per frame
    void Update()
    {
        if (!godMode && canShoot)
        {
            ShootTimer -= 1;

            if (ShootTimer <= 0 && Input.GetKey("space"))
            {
                ShootTimer = shootTimerMax;
                FindObjectOfType<AudioManager>().Play("Laser");
                Instantiate(Bullet, transform.position + new Vector3(1.2f, -.2f), Quaternion.identity);
            }
        }
        else if (canShootOverride)
        {
            ShootTimer -= 1;

            if (ShootTimer <= 0 && Input.GetKey("space"))
            {
                ShootTimer = shootTimerMax;
                FindObjectOfType<AudioManager>().Play("Laser");
                Instantiate(Bullet, transform.position + new Vector3(1.2f, -.2f), Quaternion.identity);
            }
        }
        else if(godMode && canShoot)
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
