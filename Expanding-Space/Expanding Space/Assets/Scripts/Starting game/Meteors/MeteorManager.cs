using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorManager : MonoBehaviour
{
    [SerializeField]private float ActivateTimer = 11f;
    [Range(.3f, .8f), SerializeField]private float SpawnRate = .45f;
    [SerializeField] private bool Activate = false; 
    // Start is called before the first frame update
    [SerializeField]private List<GameObject> Meteors = new List<GameObject>();
    [SerializeField] private List<Vector2> SpawnPositions = new List<Vector2>();


    private void Awake()
    {
        foreach (GameObject spawnpoint in GameObject.FindGameObjectsWithTag("SpawnPoint"))
        {
            SpawnPositions.Add(spawnpoint.GetComponent<Transform>().position);
        }
        Invoke("ActivateSpawner", ActivateTimer);
        InvokeRepeating("IncreaseDifficulty", ActivateTimer, 15f);
    }
    public void ActivateSpawner()
    {
        StartCoroutine(SpawnMeteor());
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
