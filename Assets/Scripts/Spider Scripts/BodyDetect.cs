using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BodyDetect : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame


    void OnCollisionEnter2D(Collision2D target)
    {
        if (target.gameObject.tag == "Player")
        {
            Destroy(target.gameObject);
            Application.LoadLevel("LevelMenu");
        }
    }
}
