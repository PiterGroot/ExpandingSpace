using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntroMove : MonoBehaviour
{
    [SerializeField] private TriggerDialogue introDialogue;
    [SerializeField] private SpaceShip moveScript;
    private void Awake()
    {
        moveScript.canMove = false;
        Invoke("DisableMovement", 15.5f);
    }
    private void DisableMovement()
    {
        moveScript.canMove = true;
    }
}
