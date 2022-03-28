using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class projectile : MonoBehaviour
{
    // this global variable will be set from the inspector. Represents projectile velocity
    public Vector2 projectileVelocity = new Vector2();
    public float destroy = -100;
    // function to be executed once the pipe is created
    void Start()
    {
        // setting the velocity of the rigid body component attached to the pipe
        GetComponent<Rigidbody2D>().velocity = projectileVelocity ;
    }
    // function to be executed at each frame
    void Update()
    {
        // checking x position
        if (transform.position.x < destroy)
        {
            // destroying the pipe and freeing memory and resources
            Destroy(gameObject);
        }
    }
}