using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    public float RotationSpeed = 100f; // Rotation speed


    void Update()
    {
        Rotate();
    }

    void Rotate()
    {
        float tilt = Time.time * RotationSpeed; // Setting the rotation
        transform.rotation = Quaternion.Euler(0f, 0f, tilt); // Setting the value of Z in the rotation component
    }
}
