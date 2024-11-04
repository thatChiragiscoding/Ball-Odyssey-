using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PendulumSwing : MonoBehaviour
{
    public float speed = 2.0f; // Speed of the pendulum swing
    public float maxAngle = 45.0f; // Maximum angle the pendulum will swing to either side

    private float angle; // Current angle of the pendulum

    void Update()
    {
        // Calculate the current angle using a sine wave
        angle = maxAngle * Mathf.Sin(Time.time * speed);

        // Apply the rotation to the pendulum (around the Z-axis)
        transform.localRotation = Quaternion.Euler(0, 0, angle);
    }
}
