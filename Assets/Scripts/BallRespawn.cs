using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallRespawn : MonoBehaviour
{
    public Transform respawnPoint;  // Reference to the respawn point
    public float fallThreshold = -10f;  // Y-coordinate at which the ball is considered to have fallen
    private Rigidbody rb;  // Reference to the ball's Rigidbody

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        // Check if the ball has fallen below the threshold
        if (transform.position.y < fallThreshold)
        {
            Respawn();
        }
    }

    void Respawn()
    {
        // Reset the ball's position to the respawn point's position
        transform.position = respawnPoint.position;
        transform.rotation = Quaternion.identity;  // Reset rotation to default
        rb.velocity = Vector3.zero;  // Reset velocity
    }

    private void OnCollisionEnter(Collision collision)
    {
        // Check if the ball collides with an obstacle (including the spinning blade)
        if (collision.gameObject.tag == "Obstacle")
        {
            Respawn();
        }
    }
}
