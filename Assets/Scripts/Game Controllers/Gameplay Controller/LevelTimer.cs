using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelTimer : MonoBehaviour
{
    private Slider slider;
    private GameObject player;
    public float time = 10f;
    private float timeBurn = 1f;
    // Start is called before the first frame update
    private void Awake()
    {
        GetReferences();
    }
    private void Update()
    {
        if (!player)
        {
            return;
        }
        if (time > 0)
        {
            time -= timeBurn * Time.deltaTime;
            slider.value = time;
        }
        else
        {
            GetComponent<GameplayController>().PlayerDied();
            Destroy(player);
        }
    }
    void GetReferences()
    {
        player = GameObject.Find("Player");
        slider = GameObject.Find("Time Slider").GetComponent<Slider>();
        slider.minValue = 0f;
        slider.maxValue = time;
        slider.value = slider.maxValue;

    }
}
