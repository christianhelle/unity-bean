using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] int MovementSpeed = 5;
    [SerializeField] int JumpForce = 5;
    Rigidbody rb;

    private Vector3 camRotation;
    private Vector3 moveDirection;

    [Range(-45, -15)]
    public int minAngle = -30;
    [Range(30, 80)]
    public int maxAngle = 45;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        Rotate();
    }

    private void Move()
    {
        if (Input.GetButtonDown("Jump"))
        {
            Vector3 velocity = rb.velocity;
            velocity.y = JumpForce;
            rb.velocity = velocity;
        }

        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 right = Camera.main.transform.right;
        Vector3 forward = Camera.main.transform.forward;

        forward.y = 0;
        right.y = 0;
        forward = forward.normalized;
        right = right.normalized;

        Vector3 rightRelativeHorizontalInput = horizontalInput * right;
        Vector3 forwardRelativeVerticalInput = verticalInput * forward;

        Vector3 cameraRelativeMovement = forwardRelativeVerticalInput + rightRelativeHorizontalInput;
        this.transform.Translate(cameraRelativeMovement * MovementSpeed * Time.deltaTime, Space.World);
    }

    void Rotate()
    {
        transform.Rotate(Vector3.up * Input.GetAxis("Mouse X"));
        camRotation.x -= Input.GetAxis("Mouse Y");
        camRotation.x = Mathf.Clamp(camRotation.x, minAngle, maxAngle);
        Camera.main.transform.localEulerAngles = camRotation;
    }
}
