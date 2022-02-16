using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SpawnManager : MonoBehaviour
{
    public static SpawnManager Instance;

    public List<GameObject> enemies = new List<GameObject>();

    public List<Vector2> Targets = new List<Vector2>();

    public GameObject enemyPrefabs;

    float speed = 1.5f;

    private void Awake()
    {
        Instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(UiManager.Instance.isGameActive == true)
        {
            spawnEnemy();

            sortEnemy();
        }
        
    }

    void spawnEnemy()
    {

        if (this.enemies.Count >= 36)
		{

            return;  
		}

			int index = this.enemies.Count + 1;

            Vector2 spawnPos = new Vector2(4, 4);

            GameObject enemy = Instantiate(this.enemyPrefabs, spawnPos, enemyPrefabs.transform.rotation);

            enemy.name = "Enemy Prefabs " + index;

            this.enemies.Add(enemy);
    }

    void sortEnemy()
    {
        for (int i = 0; i < enemies.Count; i++)
        {
            if (enemies[i] != null)
            {
                enemies[i].transform.position = Vector2.MoveTowards(enemies[i].transform.position, Targets[i], Time.deltaTime * speed);

            }
        }
    }
   
   
    
}
