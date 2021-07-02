using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanMove : MonoBehaviour
{
    [SerializeField] public int time = 21;
    [SerializeField] private PlayerMovement moveScript;
    // Start is called before the first frame update
    private void Awake()
    {
        moveScript.canMove = false;
        Invoke("DisableMovement", time);
    }
    private void DisableMovement()
    {
        moveScript.canMove = true;
    }
    public void Cancel(){
        CancelInvoke();
        moveScript.canMove = true;
    }
}
