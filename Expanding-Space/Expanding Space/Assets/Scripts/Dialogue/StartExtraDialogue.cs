using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartExtraDialogue : MonoBehaviour
{
    [SerializeField]private int timeInSec = 46;
    [SerializeField]private TriggerDialogue ExtraDialogue;
    
    public void StartTimers()
    {
        StartCoroutine(TimerDialogue(timeInSec));
        StartCoroutine(TimerMovement(67));
    }
    IEnumerator TimerDialogue(int timeInSeconds){
        while (timeInSeconds != 0)
        {
            yield return new WaitForSeconds(1f);
            timeInSeconds--;
        }
        ExtraDialogue.StartCoroutine(ExtraDialogue.ActivateDialogue());
    }
    IEnumerator TimerMovement(int timeInSeconds)
    {
        while (timeInSeconds != 0)
        {
            yield return new WaitForSeconds(1f);
            timeInSeconds--;
        }
        FindObjectOfType<Movement>().canMove = true;
    }
}
