using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Boss : MonoBehaviour
{
    public float Health;
    [SerializeField]private bool canShoot;
    [SerializeField]private float StartDelay;
    [SerializeField]private float DialogueTime;
    [SerializeField]private TriggerDialogue BossDialogue;
    [SerializeField]private Transform GunPos;
    [SerializeField]private GameObject bullet;
    [SerializeField]private float PauseInterval = 2.5f;
    [SerializeField]private float TriggerInterval = 1f;
    [SerializeField, Range(0, .5f)]private float ShootSpeed;
    [SerializeField]private int BulletCount;
    [SerializeField] private int BulletMultiplier;
    
    private void Start() {
        canShoot = true;
        StartCoroutine(TriggerBossDialogue());
    }
    private IEnumerator TriggerBossDialogue(){
        yield return new WaitForSeconds(StartDelay);
        //BossDialogue.StartCoroutine(BossDialogue.ActivateDialogue());
        yield return new WaitForSeconds(DialogueTime);
        StartCoroutine(ShootAttack(BulletCount, 3.5f));
    }
    private void InvokeShootAttack(){
        canShoot = true;
        StartCoroutine(ShootAttack(BulletCount, 3.5f));
    }
    private IEnumerator ShootAttack(int amountofbullets, float duration){
        Invoke("DisableShooting", duration);
            for (int i = 0; i < amountofbullets; i++){
                if(canShoot){
                    yield return new WaitForSeconds(ShootSpeed);
                    StartCoroutine(ShootBullet(BulletMultiplier)); 
                }
            }
        }
    private void DisableShooting(){
        canShoot = false;
        Invoke("InvokeShootAttack", TriggerInterval);
    }

    private IEnumerator ShootBullet(int count){
        for (int i = 0; i < count; i++){
            yield return new WaitForSeconds(ShootSpeed + 0.1f);
            Instantiate(bullet, GunPos.position, GunPos.rotation);
            FindObjectOfType<AudioManager>().Play("Laser");
        }
    }
}
