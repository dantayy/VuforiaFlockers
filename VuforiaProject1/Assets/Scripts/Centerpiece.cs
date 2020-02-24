using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//class for general scene management
//includes attributes/methods for debug lines, vehicle instantiation, and flow-field creation
public class Centerpiece : MonoBehaviour
{
    //attributes
    public GameObject initialFlocker;
    public int numFlockers;

    void OnEnable()
    {
        SpawnFlockers(initialFlocker);
        gameObject.GetComponent<BoxCollider>().enabled = true;
    }

    void OnDisable()
    {
        DespawnFlockers();
    }

    // helper function for spawning flockers
    void SpawnFlockers(GameObject flocker)
    {
        // spawn in the flockers
        for (int i = 0; i < numFlockers; i++)
        {
            Instantiate(flocker, new Vector3(Random.Range(-10, 10), Random.Range(-10, 10), Random.Range(-10, 10)), new Quaternion());
        }
    }

    // helper function for despawning flockers
    void DespawnFlockers()
    {
        // despawn flockers
        foreach (GameObject flocker in GameObject.FindGameObjectsWithTag("Flocker"))
        {
            Destroy(flocker);
        }
    }

    // helper function for changing flockers out
    public void ChangeFlockers(GameObject newFlocker)
    {
        DespawnFlockers();
        SpawnFlockers(newFlocker);
    }

}
