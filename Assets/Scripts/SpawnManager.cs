using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    private enum AnimalType
    {
        Aggresive,
        Calm
    }

    [SerializeField] private AnimalType animalType;

    [SerializeField] private GameObject[] animalPrefabs;
    [SerializeField] private float spawnRangeX;
    [SerializeField] private float spawnPosZ;

    [SerializeField] private GameObject[] animalAggresivePrefabs;
    [SerializeField] private float spawnRangeZ;
    [SerializeField] private float spawnPosX;

    [SerializeField] private float animalRotation;

    private float spawnStart = 2;
    private float spawnInterval = 1.5f;

    private void Start()
    {
        AnimalSpawnerType(animalType);
    }

    private void AnimalSpawnerType(AnimalType animalType)
    {
        if (animalType == AnimalType.Calm)
        {
            InvokeRepeating("SpawnRandomAnimal", spawnStart, spawnInterval);
        }

        if (animalType == AnimalType.Aggresive)
        {
            InvokeRepeating("SpawnRandomAggresiveAnimal", spawnStart, spawnInterval);
        }
    }

    private void SpawnRandomAnimal()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
        Instantiate(animalPrefabs[animalIndex], spawnPos, Quaternion.Euler(0, animalRotation, 0));

        Debug.DrawLine(new Vector3(spawnRangeX, 0, spawnPosZ), new Vector3(-spawnRangeX, 0, spawnPosZ), Color.green, 3);
    }

    private void SpawnRandomAggresiveAnimal()
    {
        int animalIndex = Random.Range(0, animalAggresivePrefabs.Length);
        Vector3 spawnPos = new Vector3(spawnPosX, 0, Random.Range(-spawnRangeZ, spawnRangeZ));
        Instantiate(animalAggresivePrefabs[animalIndex], spawnPos, Quaternion.Euler(0, animalRotation, 0));

        Debug.DrawLine(new Vector3(spawnPosX, 0, spawnRangeZ), new Vector3(spawnPosX, 0, -spawnRangeZ), Color.red, 3);
    }
}
