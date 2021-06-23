using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.SceneManagement;


public class CollisionManager : MonoBehaviour
{
    [SerializeField] private Animator GODMODE;
    [SerializeField] private GameObject godmode;
    [SerializeField] private bool GodMode = false;
    public int Health = 3;
    private int maxHealth;
    public int shield;
    //Zoekt het heathbar script
    public Health Healthscript;
    public ShipState Currentstate = ShipState.Undamaged;
    private void Awake()
    {
        maxHealth = Health;
        //track je max hp
    }
    public enum ShipState
    {
        Undamaged,
        SlightlyDamaged,
        VeryDamaged,
        Broken
    }
    public void DisableGOD()
    {
        godmode.SetActive(false);
    }
    private void Update()
    {
        if(Input.GetKey(KeyCode.LeftControl) && Input.GetKeyDown(KeyCode.G))
        {
            GodMode = !GodMode;
            if (GodMode)
            {
                godmode.SetActive(true);
                GODMODE.SetTrigger("GOD");
                Invoke("DisableGOD", 1.5f);
            }
        }
        if (GodMode)
        {
            Health = maxHealth;
        }
        if (Health == 3)
        {
            //update hp bar visually
            Currentstate = ShipState.Undamaged;
        }
        if (Health == 2)
        {
            //update hp bar visually
            Currentstate = ShipState.SlightlyDamaged;
        }
        if (Health == 1)
        {
            //update hp bar visually
            Currentstate = ShipState.VeryDamaged;
        }
        if (Health == 0)
        {
            //update hp bar visually
            Currentstate = ShipState.Broken;
        }
        if (Health <= 0)
        {
            print("DEAD");
            Destroy(gameObject);
            SceneManager.LoadScene("GameOver");
        }
    }
}
