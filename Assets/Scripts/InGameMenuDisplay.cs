using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InGameMenuDisplay : MonoBehaviour
{
    [SerializeField] private GameObject pauseMenu;
    [SerializeField] private GameObject scorePanel;
    [SerializeField] private GameObject deathScene;
    [SerializeField] private GameObject finishScene;
    [SerializeField] private TMP_Text scoreText;

    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = "Coins: " + 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DisplayPauseMenu()
    {
        pauseMenu.SetActive(true);
        scorePanel.SetActive(false);
        Time.timeScale = 0.0f;

    }

    public void DisplayScorePanel()
    {
        scorePanel.SetActive(true);
        pauseMenu.SetActive(false);
        Time.timeScale = 1.0f;
    }

    public void DisplayDeathScene()
    {
        scorePanel.SetActive(false);
        deathScene.SetActive(true);
    }

    public void DisplayFinishScene()
    {
        scorePanel.SetActive(false);
        finishScene.SetActive(true);
        
    }

    public void Quit()
    {
        Application.Quit();
    }

    public void UpdateScore(int playerScore)
    {
        scoreText.text = "Coins: " + playerScore.ToString();
    }

    public void PlayAgain()
    {
        SceneManager.LoadScene("Android");
    }
}
