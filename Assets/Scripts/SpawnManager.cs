using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject blockClone;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("spawningRandom", 1f, 1f);
    }

   
    private void spawningRandom()
    {
        float randomNum = Random.value;
            if (randomNum < 0.2)
            {
                Instantiate(blockClone, transform.position, blockClone.transform.rotation);
            }
            else if (randomNum < 0.4)
            {
                Instantiate(blockClone, transform.position,blockClone.transform.rotation);
            }
        else if (randomNum < 0.6)
        {
            Instantiate(blockClone, transform.position, blockClone.transform.rotation);
        }
        else
            {
                //spawn nothing;
            }
    }
}
