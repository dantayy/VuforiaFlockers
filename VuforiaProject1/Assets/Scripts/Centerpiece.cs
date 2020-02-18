using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//class for general scene management
//includes attributes/methods for debug lines, vehicle instantiation, and flow-field creation
public class Centerpiece : MonoBehaviour
{
    //attributes
    public GameObject flocker;
    public int numFlockers;

    void OnEnable()
    {
        // spawn in the flockers
        for (int i = 0; i < numFlockers; i++)
        {
            Instantiate(flocker, new Vector3(Random.Range(-10, 10), Random.Range(-10, 10), Random.Range(-10, 10)), new Quaternion());
        }
    }

    void OnDisable()
    {
        // despawn flockers
        foreach (GameObject flocker in GameObject.FindGameObjectsWithTag("Flocker"))
        {
            Destroy(flocker);
        }
    }
}
