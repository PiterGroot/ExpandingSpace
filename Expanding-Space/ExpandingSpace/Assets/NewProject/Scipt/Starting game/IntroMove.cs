using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntroMove : MonoBehaviour
{
    [SerializeField]private int time = 15;
    [SerializeField] private SpaceShip moveScript;
    private void Awake()
    {
        moveScript.canMove = false;
        Invoke("DisableMovement", time);
    }
    private void DisableMovement()
    {
        moveScript.canMove = true;
    }
}
