using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] int MovementSpeed = 5;
    [SerializeField] int JumpForce = 5;
    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
       rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 velocity = rb.velocity;
        velocity.x = horizontalInput * MovementSpeed; 
        velocity.z = verticalInput * MovementSpeed;
        
         if (Input.GetButtonDown("Jump"))
        {
            velocity.y = JumpForce;
        }

        rb.velocity = velocity;
    }
}
