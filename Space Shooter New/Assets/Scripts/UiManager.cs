using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UiManager : MonoBehaviour
{
    public static UiManager Instance;

    public List<GameObject> listCanvas;

    public bool isGameActive = false;

    public bool isGameOver = false;

    public Button MuteButton;
    public Button UnMuteButton;
    // Start is called before the first frame update
    void Start()
    {
        Instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartGame()
    {
        isGameActive = true;
        Time.timeScale = 1;
        if (isGameActive)
        {
            listCanvas[0].gameObject.SetActive(true);
            listCanvas[1].gameObject.SetActive(true);
            listCanvas[4].gameObject.SetActive(false);
            listCanvas[5].gameObject.SetActive(false);
            listCanvas[6].gameObject.SetActive(false);
            listCanvas[7].gameObject.SetActive(true);
            listCanvas[8].gameObject.SetActive(true);
            listCanvas[9].gameObject.SetActive(true);
            listCanvas[10].gameObject.SetActive(true);
            listCanvas[11].gameObject.SetActive(false);
            listCanvas[12].gameObject.SetActive(true);
            listCanvas[14].gameObject.SetActive(true);
        }
    }

    public void PauseGame()
    {
        listCanvas[12].gameObject.SetActive(false);
        listCanvas[11].gameObject.SetActive(true);
        Time.timeScale = 0;
        
    }

    public void ResumeGame()
    {
        listCanvas[11].gameObject.SetActive(false);
        listCanvas[12].gameObject.SetActive(true);
        Time.timeScale = 1;
        
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void WinnerText()
    {
        if (Boss.Instance.bossIsDead == true)
        {
            listCanvas[3].gameObject.SetActive(true);
            listCanvas[13].gameObject.SetActive(true);
            Time.timeScale = 0;
        }
    }

    public void GameOver()
    {
        isGameOver = true;

        listCanvas[1].gameObject.SetActive(true);

        listCanvas[2].gameObject.SetActive(true);

        listCanvas[13].gameObject.SetActive(true);
    }

    public void seeHighScore()
    {
        UiManager.Instance.listCanvas[1].gameObject.SetActive(true);
    }

}
