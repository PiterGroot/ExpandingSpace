using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Boss : MonoBehaviour
{
    public float Health;
    private bool canShoot;
    [SerializeField]private float StartDelay;
    [SerializeField]private float DialogueTime;
    [SerializeField]private TriggerDialogue BossDialogue;
    [SerializeField]private Transform GunPos;
    [SerializeField]private GameObject bullet;
    [SerializeField]private float PauseInterval = 2.5f;
    [SerializeField, Range(0, .5f)]private float ShootSpeed;
    [SerializeField]private int BulletCount;
    [SerializeField] private int BulletMultiplier;
    
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
        StartCoroutine(PauseShooting());
        if(canShoot){
            for (int i = 0; i < amountofbullets; i++){
                yield return new WaitForSeconds(ShootSpeed);
                StartCoroutine(ShootBullet(BulletMultiplier)); 
            }
        }
    }

    private IEnumerator PauseShooting(){
        yield return new WaitForSeconds(PauseInterval);
        
    }

    private IEnumerator ShootBullet(int count){
        for (int i = 0; i < count; i++){
            yield return new WaitForSeconds(ShootSpeed + 0.1f);
            Instantiate(bullet, GunPos.position, GunPos.rotation);
        }
    }
}
