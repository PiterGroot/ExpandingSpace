using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{

    public GameObject Bullet;
    public int ShootTimer;
    public Vector2 Spawnpoint;
    // Start is called before the first frame update
    void Start()
    {
        ShootTimer = 200;
    }

    // Update is called once per frame
    void Update()
    {
        Spawnpoint = this.gameObject.transform.position;
        ShootTimer -= 1;
   
        if (ShootTimer <= 0 && Input.GetKey("space"))
        {
            Instantiate(Bullet, Spawnpoint, Quaternion.identity);
            ShootTimer = 200;
        }
    }
}
