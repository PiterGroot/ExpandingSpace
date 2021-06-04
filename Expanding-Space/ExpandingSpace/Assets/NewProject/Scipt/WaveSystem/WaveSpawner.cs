using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class WaveSpawner : MonoBehaviour
{   
    private bool CanSpawn = true;
    [HideInInspector]public bool CountingDown = false;
    [HideInInspector]public bool SpawnedAllEnemies = false;
    List<Vector2> SpawnPositions = new List<Vector2>();
    [Tooltip("De tijd in seconden voordat de spawner begint als de game start")]
    [SerializeField] private float StartDelay;
    [Tooltip("De tijd in seconden tussen de waves")]
    [SerializeField] private float TimeBetweenWaves;
    [Tooltip("Met hoeveel enemies begint de eerste wave")]
    [Space, SerializeField] private int StartEnemyCount;
    [SerializeField] private int CurrentWave = 0;
    [Tooltip("Hoe snel of langzaan de enemies spawnen in seconden")]
    [SerializeField, Range(0, 2)] private float SpawnRate = 0.8f;
    [Tooltip("Lijst met de enemies die in de vroege rounds veel voorkomen")]
    [Space, SerializeField]List<GameObject> EasyEnemies = new List<GameObject>();
    [Tooltip("Lijst met iets moeilijkere enemeies")]
    [SerializeField]List<GameObject> MediumEnemies = new List<GameObject>();
    [Tooltip("Lijst met de sterke enemies")]
    [SerializeField]List<GameObject> HardEnemies = new List<GameObject>();
    [Tooltip("De enemies die nu in deze wave zitten")]
    [Space, SerializeField]List<GameObject> CurrentEnemies = new List<GameObject>();
    [SerializeField]private TextMeshProUGUI WaveDisplay;
    [SerializeField]private TextMeshProUGUI EnemiesLeft;
    
    private void Awake() {
        StartEnemyCount--;
        foreach (GameObject spawnpoint in GameObject.FindGameObjectsWithTag("SpawnPoint"))
        {
            SpawnPositions.Add(spawnpoint.GetComponent<Transform>().position);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(CountDownDisplay(StartDelay));
        WaveDisplay.text = $"WAVE:0";
        CurrentWave++;
    }
    private IEnumerator CountDownDisplay(float timeInSeconds)
    {
        yield return new WaitUntil(() => CanSpawn == true);
        SpawnedAllEnemies = false;
        print($"Timer for: {timeInSeconds} seconds");
        while(timeInSeconds != 0){
            CountingDown = true;
            yield return new WaitForSeconds(1f);
            timeInSeconds--;
        }
        WaveDisplay.text = $"WAVE:{CurrentWave.ToString()}";
        //next wave
        CountingDown = false;
        FillWaveSpawner();
    }

    void FillWaveSpawner(){
        CanSpawn = true;
        StartEnemyCount++;
        for (int i = 0; i < StartEnemyCount; i++){
            if(CurrentWave <= 5){
                CurrentEnemies.Add(EasyEnemies[RandInt(0, EasyEnemies.Count)]);
            }
            else if(CurrentWave <= 10 && CurrentWave > 5){
                CurrentEnemies.Add(MediumEnemies[RandInt(0, EasyEnemies.Count)]);
            }
             else if(CurrentWave >= 11){
                CurrentEnemies.Add(HardEnemies[RandInt(0, EasyEnemies.Count)]);
            }
        }
       StartCoroutine(SpawnCurrentWave());
    }
    IEnumerator SpawnCurrentWave(){
        for (int i = 0; i < CurrentEnemies.Count; i++){
            yield return new WaitForSeconds(SpawnRate);
            GameObject Enemy;
            Enemy = Instantiate(CurrentEnemies[i], SpawnPositions[RandInt(0, SpawnPositions.Count)], Quaternion.identity);
            Enemy.transform.SetParent(this.transform);
        }
        CurrentWave++;
        SpawnedAllEnemies = true;
        CanSpawn = false;
        InvokeRepeating("GetAllEnemies", 0f, 1f);
        StartCoroutine(CountDownDisplay(TimeBetweenWaves));
    }
    int RandInt(int min, int max){
        return Random.Range(min, max);
    }
    
    public void EnemyKilled(){
        CurrentEnemies.Remove(CurrentEnemies[0]);
    }

    public void GetAllEnemies(){
        if(CurrentEnemies.Count <= 0){
            CancelInvoke("GetAllEnemies");
            CanSpawn = true;
        }
    }
    private void FixedUpdate() {
        PlayerPrefs.SetInt("Wave", CurrentWave);
        EnemiesLeft.text = $"ENEMIES LEFT:{CurrentEnemies.Count.ToString()}";
        if(SpawnedAllEnemies){
            EnemiesLeft.enabled = true;
        }
        else{
            EnemiesLeft.enabled = false;
        }
    }
}
