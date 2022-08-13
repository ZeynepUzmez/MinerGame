using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class GameplayController : MonoBehaviour
{ 
    [SerializeField] private GameObject pausePanel;
    [SerializeField] private Button resumeGame;
    
    
    public void PauseGame()
    {
        Time.timeScale = 0f;
        pausePanel.SetActive(true);
        resumeGame.onClick.RemoveAllListeners();
        resumeGame.onClick.AddListener(() => ResumeGame());
    }
    public void ResumeGame()
    {
        Time.timeScale = 1f;
        pausePanel.SetActive(false);
    }
    public void GoToMenu()
    {
        Time.timeScale = 1f;
        Application.LoadLevel("LevelMenu");

    }
    public void RestartGame()
    {
        Time.timeScale = 1f;
        Application.LoadLevel("Gameplay");
    }
    public void PlayerDied()
    {
        Time.timeScale = 0f;
        pausePanel.SetActive(true);
        resumeGame.onClick.RemoveAllListeners();
        resumeGame.onClick.AddListener(() => RestartGame());

    }
    
}
