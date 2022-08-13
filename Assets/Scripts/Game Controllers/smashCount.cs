using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class smashCount : MonoBehaviour
{
    public static int smashc;
    Text SmashCount;

    // Start is called before the first frame update
    void Start()
    {
        SmashCount = GetComponent<Text>();
        smashc = PlayerPrefs.GetInt("SmashCount");
    }

    // Update is called once per frame
    void Update()
    {
        SmashCount.text = "Smash Count: " + smashc;        
    }
}
