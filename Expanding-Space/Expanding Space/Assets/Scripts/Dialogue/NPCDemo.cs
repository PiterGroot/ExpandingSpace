using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCDemo : MonoBehaviour
{
    public TriggerDialogue dialogueToTrigger;
    private void OnMouseDown()
    {
        print("Yooo");
        dialogueToTrigger.StartCoroutine(dialogueToTrigger.ActivateDialogue());
    }
}
