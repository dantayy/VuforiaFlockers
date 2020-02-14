using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//vehicle child class for flocking
//objects with this script will use separation, alignment, and cohesion methods to group up with their fellow flockers
public class Flocker : Vehicle
{
    //attributes
    public float separationWeight;
    public float alignmentWeight;
    public float cohesionWeight;
    public float seekWeight;

    protected override void CalcSteeringForces()
    {
        Vector3 ultimateForce = new Vector3();
        //flocking forces
        ultimateForce += Separation(GameObject.FindGameObjectsWithTag("Flocker")) * separationWeight;
        ultimateForce += Alignment(GameObject.FindGameObjectsWithTag("Flocker")) * alignmentWeight;
        ultimateForce += Cohesion(GameObject.FindGameObjectsWithTag("Flocker")) * cohesionWeight;
        ultimateForce += Seek(GameObject.Find("Centerpiece").transform.position) * seekWeight;
        //seeking centerpiece force
        ultimateForce = ultimateForce.normalized * maxForce;
        ApplyForce(ultimateForce);
    }
}
