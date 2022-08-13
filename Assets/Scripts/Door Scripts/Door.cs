using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Door : MonoBehaviour
{
    
    public static Door instance;
    private Animator anim;
    private BoxCollider2D box;
    [HideInInspector] public int collactablesCount;
    private void Awake()
    {
        MakeInstance();
        anim = GetComponent<Animator>();
        box = GetComponent<BoxCollider2D>();

    }
    void MakeInstance()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
    public void DecreementCollectables()
    {
        collactablesCount--;
        if (collactablesCount == 0)
        {
            StartCoroutine(OpenDoor());
        }
    }
    IEnumerator OpenDoor()
    {
        anim.Play("Open");
        yield return new WaitForSeconds(.7f);
        box.isTrigger = true;
    }
     void OnTriggerEnter2D(Collider2D target)
    {
        if (target.tag=="Player")
        {
            
            GameObject.Find("Gameplay Controller").GetComponent<GameplayController>().PlayerDied();
            NextLevelController();
            SceneManager.LoadScene("LevelMenu");
            
        }
    }

    private void NextLevelController()
    {
        string currentLevel = PlayerPrefs.GetString("currentLevel");
        int currentLevelID = int.Parse(currentLevel.Split("_")[1]);
        int nextLevel = PlayerPrefs.GetInt("level") + 1;
        if (currentLevelID == PlayerPrefs.GetInt("levelCount"))
        {
            Debug.Log("FÝNÝSH");
        }
        else
        {
            if ( nextLevel - currentLevelID == 1)
                PlayerPrefs.SetInt("level", nextLevel);
            else
                Debug.Log("Already unlocked");
        }
    }
    


}
