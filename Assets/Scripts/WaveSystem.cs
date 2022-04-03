using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveSystem : MonoBehaviour
{
    int round;
    int numberToSpawn;
    public GameObject warrok;
    public GameObject nightshade;
    public GameObject skeleton;
    List<GameObject> listEnemies = new List<GameObject>();
    Vector3 spawnPoint;

    // Start is called before the first frame update
    void Start()
    {
        round = 1;
        numberToSpawn = 0;
        spawnPoint = GameObject.Find("SpawnPoint").transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (listEnemies.Count == 0)
        {
            startNextWave();
        }
    }

    void startNextWave()
    {
        spawnMonsters();
        round += 1;
    }

    void spawnMonsters()
    {
        numberToSpawn += 2 + (round * 2);
        // Here, we create a random number ranging from 1 to 3 to create a random enemy every runtime.
        for (int i = 0; i < numberToSpawn; i++)
        {
            int typeOfEnemy = generateRandomNumber();
            switch (typeOfEnemy)
            {
                case 1:
                    listEnemies.Add(Instantiate(warrok, spawnPoint, Quaternion.identity));
                    break;
                case 2:
                    listEnemies.Add(Instantiate(warrok, spawnPoint, Quaternion.identity));
                    break;
                case 3:
                    listEnemies.Add(Instantiate(warrok, spawnPoint, Quaternion.identity));
                    break;
            }
        }
    }

    int generateRandomNumber()
    {

        int typeOfEnemy = UnityEngine.Random.Range(1, 4);
        return typeOfEnemy;
    }
}
