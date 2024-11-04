using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 30f;
    public float jumpForce = 10f; // Jumping force
    public Rigidbody rigid;

    private float xInput;
    private float zInput;
    private bool isGrounded; // Check if player is on the ground

    // Update is called once per frame
    void Update()
    {
        Inputs();
        Jump(); // Check for jump input
    }

    private void FixedUpdate()
    {
        Move();
    }

    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody>();
    }

    private void Inputs()
    {
        xInput = Input.GetAxis("Horizontal");
        zInput = Input.GetAxis("Vertical");
    }

    private void Move()
    {
        rigid.AddForce(new Vector3(xInput, 0f, zInput) * speed);
    }

    private void Jump()
    {
        // Check for jump input and if the player is grounded
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rigid.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isGrounded = false; // Set to false to prevent double jumping
        }
    }

    // Unity method that is called when the collider starts touching another collider
    private void OnCollisionEnter(Collision collision)
    {
        // Check if the collision is with the ground
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
    }
}
