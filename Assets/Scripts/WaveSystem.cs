using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveSystem : MonoBehaviour
{
    // Variables
    public static WaveSystem waveSystem;
    int round = 1;
    public int numberToSpawn = 2;
    public int numberToAddEachRound = 2;
    bool waveQueued = false;
    public GameObject warrok;
    public GameObject nightshade;
    public GameObject skeleton;
    private System.Random random = new System.Random();
    private List<GameObject> listEnemies = new List<GameObject>();
    Vector3 spawnPoint;


    // Accessible properties
    public List<GameObject> ListEnemies { get { return this.listEnemies; } }
    public int Round { get { return this.round; } }

    /// <summary>
    /// Functions
    /// </summary>
    private void Awake()
    {
        waveSystem = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        spawnPoint = GameObject.Find("SpawnPoint").transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (listEnemies.Count == 0 && waveQueued == false)
        {
            Invoke("startNextWave", 5f);
            waveQueued = true;
        }
    }

    void startNextWave()
    {
        spawnMonsters();
        round += 1;
    }

    void spawnMonsters()
    {
        for (int i = 0; i < numberToSpawn; i++)
        {
            // The Invoke here makes it that every enemy spawns at an interval of 0.5f
            Invoke("spawnEnemy", 0.5f + 0.5f*i);
        }
        numberToSpawn += numberToAddEachRound;
    }

    int generateRandomNumber()
    {
        // We roll a dice for a number between 1 to 3 to randomly select the next type of enemy to spawn
        random = new System.Random();
        return random.Next(1,4);
    }

    void spawnEnemy()
    {
        // This section decides what to spawn according to the number we got from the function down below
        switch (generateRandomNumber())
        {
            case 1:
                // In case of a number 1, we spawn a warrok
                instantiateEnemy(warrok);
                break;
            case 2:
                // In case of a number 2, we spawn a nightshade
                instantiateEnemy(nightshade);
                break;
            case 3:
                // In case of a number 3, we spawn a skeleton
                instantiateEnemy(skeleton);
                break;
        }
    }

    void addEnemyToList(GameObject enemy)
    {
        listEnemies.Add(enemy);
    }

    public void RemoveEnemyFromList(GameObject enemy)
    {
        listEnemies.Remove(enemy);
    }
    void instantiateEnemy(GameObject monster)
    {
        // We add the enemy to the monster list to easily have access to all monster later in the game
        GameObject enemy = Instantiate(monster, spawnPoint, Quaternion.identity);
        addEnemyToList(enemy);
        enemy.GetComponent<Enemy>().SetEnemyHP();
    }
}
