using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeadDetect : MonoBehaviour
{
    GameObject Enemy;
    void Start()
    {
        Enemy = gameObject.transform.parent.gameObject;
        
    }

    // Update is called once per frame
    private void OnCollisionEnter2D(Collision2D  target)
    {
        if (target.gameObject.tag == "Player")
        {
            Destroy(Enemy);
            smashCount.smashc += 1;
            PlayerPrefs.SetInt("SmashCount", smashCount.smashc);
        }
        }
}
