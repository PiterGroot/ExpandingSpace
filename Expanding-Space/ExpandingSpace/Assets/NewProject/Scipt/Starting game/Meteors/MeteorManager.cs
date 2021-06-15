using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorManager : MonoBehaviour
{

    private List<Vector2> SpawnPositions = new List<Vector2>();
    private float TimeBetweenWaves = 15f;
    private bool canSpawn = false;
    [SerializeField] private int CurrentWave;
    [SerializeField]private float ActivateTimer = 11f;
    [Range(.3f, .8f), SerializeField]private float SpawnRate = .45f;
    [SerializeField] private bool Activate = false; 
    // Start is called before the first frame update
    [SerializeField]private List<GameObject> Meteors = new List<GameObject>();


    private void Awake()
    {
        foreach (GameObject spawnpoint in GameObject.FindGameObjectsWithTag("SpawnPoint"))
        {
            SpawnPositions.Add(spawnpoint.GetComponent<Transform>().position);
        }
        Invoke("ActivateSpawner", ActivateTimer);
        StartCoroutine(DisableTimer(15f));
        CurrentWave++;
    }
    private IEnumerator DisableTimer(float timeInSeconds){
        while (timeInSeconds != 0){
            yield return new WaitForSeconds(1f);
            timeInSeconds--;
        }
        canSpawn = false;
    }
    private IEnumerator NextWaveTimer(float timeInSeconds)
    {
        while (timeInSeconds != 0)
        {
            yield return new WaitForSeconds(1f);
            timeInSeconds--;
        }
        CurrentWave++;
    }
    public void ActivateSpawner()
    {
        if (canSpawn)
        {
            StartCoroutine(SpawnMeteor());
        } 
    }
    public void IncreaseDifficulty()
    {
        SpawnRate -= .03f;
    }
    private IEnumerator SpawnMeteor()
    {
        yield return new WaitForSeconds(SpawnRate);
        GameObject Meteor;
        Meteor = Instantiate(Meteors[RandInt(0, Meteors.Count)], SpawnPositions[RandInt(0, SpawnPositions.Count)], Quaternion.identity);
        Meteor.transform.parent = gameObject.transform;
        ActivateSpawner();
    }
    int RandInt(int min, int max)
    {
        return Random.Range(min, max);
    }
    private void Update()
    {
        if (Activate)
        {
            Activate = false;
            ActivateSpawner();
        }
    }
}
