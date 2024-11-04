using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinningBlade : MonoBehaviour
{
    public float rotationSpeed = 100.0f;  // Speed of the blade rotation

    void Update()
    {
        // Rotate the blade around the Y-axis
        transform.Rotate(0, rotationSpeed * Time.deltaTime, 0);
    }
}
