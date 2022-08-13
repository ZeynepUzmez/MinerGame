using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelController : MonoBehaviour

{
    
    
    [SerializeField] private GameObject HowToPlayPanel;

    /* public void PlayGame()
     {
         Application.LoadLevel("GamePlay");
     }*/
    public void BackToMenu()
     {
         Application.LoadLevel("MainMenu");
     }
    public List<Button> levels;
    private void Start()
    {
        if (!PlayerPrefs.HasKey("level"))
            PlayerPrefs.SetInt("level", 1);
        if (!PlayerPrefs.HasKey("levelCount"))
            PlayerPrefs.SetInt("levelCount", levels.Count);
        Unlock();
    }
    public void Unlock()
    {
        for (int i = 0; i < PlayerPrefs.GetInt("level"); i++)
        {
            levels[i].interactable = true;

        }
    }
    public string LevelName(int id)
    {
        string scenePath = SceneUtility.GetScenePathByBuildIndex(id);
        string sceneName = System.IO.Path.GetFileNameWithoutExtension(scenePath);
        return sceneName;
    }
    public void unlockLevel(int id)
    {
        PlayerPrefs.SetString("currentLevel", LevelName(id));
        SceneManager.LoadScene(LevelName(id));

    }
    public void Refresh()
    {
        PlayerPrefs.DeleteKey("level");
        PlayerPrefs.DeleteKey("currentLevel");
        PlayerPrefs.DeleteKey("levelCount");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void HowToPLay()
    {
      HowToPlayPanel.SetActive(true);
    }
    public void BackToLevel()
    {
        
        HowToPlayPanel.SetActive(false);
    }
     
}
