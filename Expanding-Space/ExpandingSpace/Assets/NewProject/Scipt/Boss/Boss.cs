using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.SceneManagement;

public class Boss : MonoBehaviour
{
    private bool canDie = false;
    private int WaveCount;
    public float Health;
    private float maxHealth = 80;
    [SerializeField] private ParticleSystem bigexplosion;
    [SerializeField] private Animator bossanim;
    [SerializeField] private float FlightDuration = 7;
    [SerializeField] private int ShootWaves = 5;
    [SerializeField] private float StartDelay;
    [SerializeField] private float DialogueTime;
    [SerializeField] private TriggerDialogue BossDialogue, BossFly;
    [SerializeField] private Transform GunPos;
    [SerializeField] private GameObject bullet;
    [SerializeField] private float PauseInterval = 2.5f;
    [SerializeField] private float TriggerInterval = 1f;
    [SerializeField, Range(0, .5f)] private float ShootSpeed;
    [SerializeField] private int BulletCount;
    [SerializeField] private int BulletMultiplier;
    public bool canShoot;

    private void Start()
    {
        canDie = false;
        Health = maxHealth;
        GameObject.FindGameObjectWithTag("healthbar").transform.GetChild(0).gameObject.SetActive(true);
        BossFly = GameObject.FindGameObjectWithTag("BossDialogue1").GetComponent<TriggerDialogue>();
        BossDialogue = GameObject.FindGameObjectWithTag("BossDialogue").GetComponent<TriggerDialogue>();
        canShoot = true;
        StartCoroutine(TriggerBossDialogue());
    }
    private IEnumerator TriggerBossDialogue()
    {
        yield return new WaitForSeconds(StartDelay);
        BossDialogue.StartCoroutine(BossDialogue.ActivateDialogue());
        yield return new WaitForSeconds(DialogueTime);
        StartCoroutine(ShootAttack(BulletCount, 3.5f));
        canDie = true;
    }
    private void InvokeShootAttack()
    {
        canShoot = true;
        StartCoroutine(ShootAttack(BulletCount, 3.5f));
    }
    private void InvokeShootFlyAttack()
    {
        canShoot = true;
        StartCoroutine(ShootFlyAttack(BulletCount, 3.5f));
    }
    private IEnumerator ShootAttack(int amountofbullets, float duration)
    {
        WaveCount++;
        if (WaveCount < ShootWaves)
        {
            Invoke("DisableShooting", duration);
            for (int i = 0; i < amountofbullets; i++){
                if (canShoot){
                    yield return new WaitForSeconds(ShootSpeed);
                    StartCoroutine(ShootBullet(BulletMultiplier));
                }
            }
        }
        else{
            BossFly.StartCoroutine(BossFly.ActivateDialogue());
            bossanim.SetBool("isFlying", true);
            WaveCount = 0;
            Invoke("DisableSFlyhooting", duration);
        }
    }
    private IEnumerator ShootFlyAttack(int amountofbullets, float duration){
            Invoke("DisableSFlyhooting", duration);
            for (int i = 0; i < amountofbullets; i++){
                if (canShoot){
                    yield return new WaitForSeconds(ShootSpeed);
                    StartCoroutine(ShootBullet(BulletMultiplier));
                }
            }
    }
    public void TakeDamage(){
        Health -= UnityEngine.Random.Range(1, 5);
    }
    private void DisableShooting(){
        canShoot = false;
        Invoke("InvokeShootAttack", TriggerInterval);
    }
     private void DisableSFlyhooting(){
        canShoot = false;
        Invoke("InvokeShootFlyAttack", TriggerInterval);
    }
    private IEnumerator ShootBullet(int count){
        for (int i = 0; i < count; i++){
            yield return new WaitForSeconds(ShootSpeed + 0.1f);
            Instantiate(bullet, GunPos.position, GunPos.rotation);
            FindObjectOfType<AudioManager>().Play("Laser");
        }
    }
    private void Update(){
        if(!canDie){
            Health = maxHealth;
        }
        if(Health <= 0 && canDie){
            canDie = false;
            transform.position = new Vector3(0, -200, 0);
            Instantiate(bigexplosion, new Vector3(0, 0, 0), Quaternion.identity);
            RandomExplosionSound();
            Invoke("LoadScene", 2f);
        }
    }
    private void LoadScene()
    {
        SceneManager.LoadScene("end screen 1");
        Destroy(gameObject);
    }
    private void RandomExplosionSound()
    {
        int randInt = UnityEngine.Random.Range(0, 3);
        switch (randInt)
        {
            case 0:
                FindObjectOfType<AudioManager>().Play("Explosion");
                break;
            case 1:
                FindObjectOfType<AudioManager>().Play("Explosion1");
                break;
            case 2:
                FindObjectOfType<AudioManager>().Play("Explosion2");
                break;
            case 3:
                FindObjectOfType<AudioManager>().Play("Explosion3");
                break;
        }
    }
}
