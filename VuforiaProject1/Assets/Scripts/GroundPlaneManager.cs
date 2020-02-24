using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundPlaneManager : MonoBehaviour
{
    void Awake()
    {
        gameObject.GetComponent<BoxCollider>().enabled = true;
    }
}
