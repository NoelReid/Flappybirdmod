using UnityEngine;
using System.Collections;

public class PipeScript : MonoBehaviour
{

    // this global variable will be set from the inspector. Represents pipe velocity
    public Vector2 pipeVelocity = new Vector2();

    // function to be executed once the pipe is created
    void Start()
    {
        // setting the velocity of the rigid body component attached to the pipe
        GetComponent<Rigidbody2D>().velocity = pipeVelocity;
    }
    // function to be executed at each frame
    void Update()
    {
        // checking x position
        if (transform.position.x < -5)
        {
            // destroying the pipe and freeing memory and resources
            Destroy(gameObject);
        }
    }
        
public class PipeSpeed : MonoBehaviour
    {
        public GameObject pipe;
        public float speedOfPipe = -2f;
        public int getFaster = 2;

        // Start is called before the first frame update
        void Start()
        {
            pipe.GetComponent<PipeScript>().pipeVelocity = new Vector2(speedOfPipe, 0);
        }

        // Update is called once per frame
        void FixedUpdate()
        {
            if (Time.time % getFaster == 0)
            {
                speedOfPipe = speedOfPipe - 1f;
                pipe.GetComponent<PipeScript>().pipeVelocity = new Vector2(speedOfPipe, 0);
            }
        }
    }

}
    
