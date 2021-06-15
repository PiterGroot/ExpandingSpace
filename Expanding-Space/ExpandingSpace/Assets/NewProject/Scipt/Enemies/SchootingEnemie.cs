using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SchootingEnemie : MonoBehaviour
{
    int timer;
    int ShootTimer;
    public GameObject Bullet;
    public Vector2 Spawnpoint;
    // Start is called before the first frame update
    void Start()
    {
        timer = 500;
        ShootTimer = 600;
    }

    // Update is called once per frame
    void Update()
    {
        Spawnpoint = this.gameObject.transform.position;
        timer -= 1;
        ShootTimer -= 1;
        if(timer <= 0)
        {
            if (ShootTimer <= 0)
            {
                ShootTimer = 600;
                Instantiate(Bullet, Spawnpoint, Quaternion.identity);
            }
        }

    }
}
