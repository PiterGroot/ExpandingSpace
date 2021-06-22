using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossSpawner : MonoBehaviour
{
    private WaveSpawner spawnerScript;
    [SerializeField]private bool TriggerBossFight;
    [SerializeField]private Transform SpawnPosition;
    [SerializeField]private GameObject BossObj;
    
    private void Awake() {
        spawnerScript = FindObjectOfType<WaveSpawner>();
    }
    // Start is called before the first frame update
    public void TriggerFight(){
        spawnerScript.StartedBossFight();
        Instantiate(BossObj, SpawnPosition.transform.position, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        if(TriggerBossFight){
            TriggerBossFight = false;
            TriggerFight();
        }
    }
}
