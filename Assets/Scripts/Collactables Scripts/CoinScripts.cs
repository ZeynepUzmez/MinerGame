using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinScripts : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if (Door.instance != null)
        {
            Door.instance.collactablesCount++;
        }
        
    }

    private void OnTriggerEnter2D(Collider2D target)
    {
        if (target.tag == "Player")
        {
            Destroy(gameObject);
            
            if (Door.instance != null)
            {
                Door.instance.DecreementCollectables();
            }
            
        }
    }
}
