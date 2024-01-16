using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OscillateObject : MonoBehaviour
{
    public float oscillationAngle = 45f; // Oscillation angle in degrees
    public float frequency = 2f; // Oscillation frequency

    private void Update()
    {
        OscillateMovement();
    }

    void OscillateMovement()
    {
        float tilt = Mathf.Sin(Time.time * frequency) * oscillationAngle; // sin of the freq times the oscillation angle.
        transform.rotation = Quaternion.Euler(0f, 0f, tilt); // Setting the value of Z in the rotation component
    }
}
