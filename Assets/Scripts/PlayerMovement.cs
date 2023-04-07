using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] int MovementSpeed = 5;
    [SerializeField] int JumpForce = 5;
    Rigidbody rb;

    private Vector3 camRotation;
    private Transform cam;
    private Vector3 moveDirection;

    [Range(-45, -15)]
    public int minAngle = -30;
    [Range(30, 80)]
    public int maxAngle = 45;
    [Range(50, 500)]
    public int sensitivity = 200;

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

        //Rotate();
    }
    
    //void Rotate()
    //{
    //    transform.Rotate(Vector3.up * sensitivity * Time.deltaTime * Input.GetAxis("Mouse X"));

    //    camRotation.x -= Input.GetAxis("Mouse Y") * sensitivity * Time.deltaTime;
    //    camRotation.x = Mathf.Clamp(camRotation.x, minAngle, maxAngle);

    //    cam.localEulerAngles = camRotation;
    //}
}
