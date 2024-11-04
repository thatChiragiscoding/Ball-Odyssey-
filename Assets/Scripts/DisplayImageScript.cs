using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class DisplayImageScript : MonoBehaviour
{
    public Image imageToDisplay;  // Reference to the image UI element
    public float displayTime = 5f;  // How long the image should be displayed (in seconds)

    void Start()
    {
        StartCoroutine(DisplayImageForTime());
    }

    IEnumerator DisplayImageForTime()
    {
        // Enable the image for the specified time
        imageToDisplay.enabled = true;

        // Wait for the display time (5 seconds)
        yield return new WaitForSeconds(displayTime);

        // Hide the image after the time is up
        imageToDisplay.enabled = false;
    }
}

