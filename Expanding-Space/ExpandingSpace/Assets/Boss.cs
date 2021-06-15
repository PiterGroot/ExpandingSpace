

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Boss : MonoBehaviour
{
    public float Health;
    [SerializeField]private Animator gunAnim;
    [SerializeField]private float StartDelay;
    [SerializeField]private float DialogueTime;
    [SerializeField]private TriggerDialogue BossDialogue;
    [SerializeField]private Transform GunPos;
    [SerializeField]private GameObject bullet;
    [SerializeField, Range(.05f, .5f)]private float ShootSpeed;
    [SerializeField]private int BulletCount;
    private void Start() {
        StartCoroutine(TriggerBossDialogue());
    }
    private IEnumerator TriggerBossDialogue(){
        yield return new WaitForSeconds(StartDelay);
        BossDialogue.StartCoroutine(BossDialogue.ActivateDialogue());
        yield return new WaitForSeconds(DialogueTime);
        StartCoroutine(ShootAttack(BulletCount));
    }

    private IEnumerator ShootAttack(int amountofbullets){
        gunAnim.SetBool("CanShoot", true);
        for (int i = 0; i < amountofbullets; i++){
            yield return new WaitForSeconds(ShootSpeed);
            Instantiate(bullet, GunPos.position, GunPos.rotation);   
        }
        gunAnim.SetBool("CanShoot", false);
    }
}
