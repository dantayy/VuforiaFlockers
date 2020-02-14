using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//class for general scene management
//includes attributes/methods for debug lines, vehicle instantiation, and flow-field creation
public class Manager : MonoBehaviour
{
    //manager reference shortcut: use `Manager.Instance.` instead of `GameObject.Find("Manager").GetComponent<Manager>().`
    private static Manager instance;

    public static Manager Instance
    {
        get { return instance; }
    }

    //attributes
    public GameObject flocker;
    public int numFlockers;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Debug.LogError("Two managers in a scene!");
        }
    }

    // Use this for initialization
    void Start()
    {
        //spawn in the flockers
        for (int i = 0; i < numFlockers; i++)
        {
            Instantiate(flocker, new Vector3(Random.Range(-10, 10), Random.Range(-10, 10), Random.Range(-10, 10)), new Quaternion());
        }
    }
}
