using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.SceneManagement;


public class CollisionManager : MonoBehaviour
{
    [SerializeField]private bool GodMode = false;
    public int Health = 3;
    private int maxHealth;
    public ShipState Currentstate = ShipState.Undamaged;
    private void Awake() {
        maxHealth = Health;
    }
    public enum ShipState
    {
        Undamaged,
        SlightlyDamaged,
        VeryDamaged,
        Broken
    }
    private void Update()
    {
        if(GodMode){
            Health = maxHealth;
        }
        if (Health == 3)
        {
            Currentstate = ShipState.Undamaged;
        }
        if (Health == 2)
        {
            Currentstate = ShipState.SlightlyDamaged;
        }
        if (Health == 1)
        {
            Currentstate = ShipState.VeryDamaged;
        }
        if (Health == 0)
        {
            Currentstate = ShipState.Broken;
        }
        if(Health <= 0)
        {
            print("DEAD");
            Destroy(gameObject);
            SceneManager.LoadScene("Level1Meteorites");
        }
    }
}
