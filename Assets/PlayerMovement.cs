using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 velocity = GetComponent<Rigidbody>().velocity;
        if (Input.GetKeyDown("space"))
        {
            velocity.y = 5;
            //GetComponent<Rigidbody>().velocity = new Vector3(0, 5, 0);
        }

        if (Input.GetKey("up") || Input.GetKey("w"))
        {
            //GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 5);
            velocity.z = 1;
        }

        if (Input.GetKey("right") || Input.GetKey("d"))
        {
            //GetComponent<Rigidbody>().velocity = new Vector3(5, 0, 0);
            velocity.x = 1;
        }
        
        if (Input.GetKey("left") || Input.GetKey("a"))
        {
            //GetComponent<Rigidbody>().velocity = new Vector3(-5, 0, 0);
            velocity.x = -1;
        }
        
        if (Input.GetKey("down")|| Input.GetKey("s"))
        {
            //GetComponent<Rigidbody>().velocity = new Vector3(0, 0, -5);
            velocity.z = -1;
        }

         GetComponent<Rigidbody>().velocity = velocity;
    }
}
