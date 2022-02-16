using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpawnAllScripts : MonoBehaviour
{
    public static SpawnAllScripts Instance;

    

    public List<GameObject> spawnManagerPrefab;

    // Start is called before the first frame update
    void Start()
    {
        Instance = this;
    }

    // Update is called once per frame
        void Update()
    {

		if (ScoreManager.instance.score >= 36)
		{
            

            spawnManagerPrefab[0].gameObject.SetActive(false);
			spawnManagerPrefab[1].gameObject.SetActive(true);
		}

		if (ScoreManager.instance.score >= 56)
		{
            
            spawnManagerPrefab[1].gameObject.SetActive(false);
            spawnManagerPrefab[2].gameObject.SetActive(true);
        }

        if (ScoreManager.instance.score >= 69)//
        {
           
            spawnManagerPrefab[2].gameObject.SetActive(false);
            spawnManagerPrefab[3].gameObject.SetActive(true);
        }

        if (ScoreManager.instance.score >= 92)
        {
            spawnManagerPrefab[3].gameObject.SetActive(false);
            spawnManagerPrefab[4].gameObject.SetActive(true);
        }

        if (ScoreManager.instance.score >= 104)
        {
            spawnManagerPrefab[4].gameObject.SetActive(false);
            spawnManagerPrefab[5].gameObject.SetActive(true);
        }

        if (ScoreManager.instance.score >= 122)//
        {
            
            spawnManagerPrefab[5].gameObject.SetActive(false);
            spawnManagerPrefab[6].gameObject.SetActive(true);
        }

        if (ScoreManager.instance.score >= 152)
        {
            spawnManagerPrefab[6].gameObject.SetActive(false);
            spawnManagerPrefab[7].gameObject.SetActive(true);
        }

        if (ScoreManager.instance.score >= 165)
        {
            spawnManagerPrefab[7].gameObject.SetActive(false);
            spawnManagerPrefab[8].gameObject.SetActive(true);
        }

        if (ScoreManager.instance.score >= 178)//
        {
            spawnManagerPrefab[8].gameObject.SetActive(false);
            spawnManagerPrefab[9].gameObject.SetActive(true);
        }

        if (ScoreManager.instance.score >= 222)
        {
            spawnManagerPrefab[9].gameObject.SetActive(false);

            Boss.Instance.boss.gameObject.SetActive(true);
            Boss.Instance.BossMove();

            if (Boss.Instance.bossIsDead == true)
			{
                UiManager.Instance.listCanvas[3].gameObject.SetActive(true);
                UiManager.Instance.listCanvas[13].gameObject.SetActive(true);
                Time.timeScale = 0;
			}

            

        }

    }

    
}
