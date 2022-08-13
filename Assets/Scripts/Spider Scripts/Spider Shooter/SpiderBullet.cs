using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpiderBullet : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D target)
    {
        if (target.tag == "Player")
        {
            Destroy(target.gameObject);//Playeri oldurmek icin
            Destroy(gameObject);//bulleti yok etmek icin
            Application.LoadLevel("LevelMenu");
        }
        if (target.tag == "Ground")
        {
            Destroy(gameObject);//yere carpan bulleti yok etmek icin
        }
    }
}
