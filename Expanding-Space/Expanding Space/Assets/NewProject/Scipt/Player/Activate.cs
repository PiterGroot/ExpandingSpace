using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activate : MonoBehaviour
{
    //de quest
    [Header("Dialogue")]
    [SerializeField]private TriggerDialogue Partnerdialogue;
    [SerializeField] private TriggerDialogue ShopWelkomdialogue;
    [SerializeField] private TriggerDialogue ShopEindeDialogue;

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
            if(colelider.gameObject.name == "Shop")
            {
                ShopWelkomdialogue.StartCoroutine(ShopWelkomdialogue.ActivateDialogue());
            }
            if(colelider.gameObject.name == "Partner")
            {
                Partnerdialogue.StartCoroutine(Partnerdialogue.ActivateDialogue());
            }
            
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        //quest.SetActive(false);
        canTalk = false;
    }
}
