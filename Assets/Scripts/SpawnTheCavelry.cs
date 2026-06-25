using UnityEngine;
using UnityEngine.InputSystem;

public class SpawnTheCavelry : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    public InputAction spawnAction;
    private float spawnRangeX = 10f;
    private float spawnPosZ = 20f;
    private float spawnDelay = 2f;
    private float spawnInterval = 1.5f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("SpawnRandomCavelry", spawnDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    void SpawnRandomCavelry()
    {
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
            int animalIndex = Random.Range(0, animalPrefabs.Length);
            Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
    }
}
