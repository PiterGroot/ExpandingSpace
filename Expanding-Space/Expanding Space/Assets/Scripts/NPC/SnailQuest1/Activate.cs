using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activate : MonoBehaviour
{
    //de quest
    [Header("Dialogue")]
    [SerializeField]private TriggerDialogue Bosjesdialogue;
    [SerializeField] private TriggerDialogue Randomdialogue;
    [SerializeField] private TriggerDialogue KindergardenDialogue;
    [SerializeField] private TriggerDialogue Snail1Random;
    [SerializeField] private TriggerDialogue Snail2Random;
    public GameObject quest;
    public bool canTalk = false;  //check als je bij de npc sta
    private Collider2D colelider;
    void OnCollisionEnter2D(Collision2D collisionInfo)
    {
        if (collisionInfo.collider.tag == "Npc")
        {
            colelider = collisionInfo.collider;
            canTalk = true;
        }
    }
    void Update()
    {
        if (canTalk == true && Input.GetKey("f"))
        {
            //quest.SetActive(true);
            if(colelider.gameObject.name == "npcBosjes")
            {
                Bosjesdialogue.StartCoroutine(Bosjesdialogue.ActivateDialogue());
            }
            if(colelider.gameObject.name == "npcRandom")
            {
                Randomdialogue.StartCoroutine(Randomdialogue.ActivateDialogue());
            }
            if (colelider.gameObject.name == "npcKindergarden")
            {
                KindergardenDialogue.StartCoroutine(KindergardenDialogue.ActivateDialogue());
            }
            if(colelider.gameObject.name == "Snail1")
            {
                Snail1Random.StartCoroutine(Snail1Random.ActivateDialogue());
            }
            if (colelider.gameObject.name == "Snail2")
            {
                Snail2Random.StartCoroutine(Snail2Random.ActivateDialogue());
            }
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        //quest.SetActive(false);
        canTalk = false;
    }
}
