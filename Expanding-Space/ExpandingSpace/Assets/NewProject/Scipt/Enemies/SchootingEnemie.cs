using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SchootingEnemie : MonoBehaviour
{

    int ShootTimer;
    public GameObject Bullet;
    public Vector2 Spawnpoint;
    // Start is called before the first frame update
    void Start()
    {

        ShootTimer = 0;
    }

    // Update is called once per frame
    void Update()
    {
        Spawnpoint = this.gameObject.transform.position;

        ShootTimer -= 1;
        if(transform.position.x <= 8)
        {
            if (ShootTimer <= 0)
            {
                ShootTimer = 600;
                FindObjectOfType<AudioManager>().Play("Laser");
                Instantiate(Bullet, Spawnpoint, Quaternion.identity);
            }
        }

    }
}
