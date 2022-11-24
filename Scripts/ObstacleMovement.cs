using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMovement : MonoBehaviour
{
   
    public Rigidbody rb1;
    public float forwardForce = -1500f;
    // Update is called once per frame
    
    void FixedUpdate()
    {
        rb1.AddForce(0, 0, forwardForce * Time.deltaTime);
         
    }
}
