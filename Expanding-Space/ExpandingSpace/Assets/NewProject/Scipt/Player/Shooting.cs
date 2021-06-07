using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    [SerializeField] private bool godMode;
    public GameObject Bullet;
    public int ShootTimer;
    [HideInInspector]public int shootTimerMax;
    public Vector2 Spawnpoint;
    private void Awake(){
        shootTimerMax = ShootTimer;
    }

    // Update is called once per frame
    void Update()
    {
        if (!godMode)
        {
            Spawnpoint = this.gameObject.transform.position;
            ShootTimer -= 1;

            if (ShootTimer <= 0 && Input.GetKey("space"))
            {
                ShootTimer = shootTimerMax;
                FindObjectOfType<AudioManager>().Play("Laser");
                Instantiate(Bullet, Spawnpoint, Quaternion.identity);
            }
        }
        else
        {
            Spawnpoint = this.gameObject.transform.position;
            ShootTimer -= 1;

            if (ShootTimer <= 0 && Input.GetKey("space"))
            {
                ShootTimer = 0;
                FindObjectOfType<AudioManager>().Play("Laser");
                Instantiate(Bullet, Spawnpoint + new Vector2(0, 1f), Quaternion.identity);
                Instantiate(Bullet, Spawnpoint + new Vector2(0, -1f), Quaternion.identity);
                Instantiate(Bullet, Spawnpoint, Quaternion.identity);
            }
        }
    }
}
