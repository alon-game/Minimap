using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartBeat : MonoBehaviour
{
    public float maxSize = 0.2f; // max size
    public float minSize = 0.1f; // min size
    public float growthSpeed = 0.2f; // increase and decrease speed
    private bool isGrowing = true; // growing flag

    private void Update()
    {
        ScaleObject();
    }

    void ScaleObject()
    {
        // Determining the current size of the object
        float currentSize = transform.localScale.x;

        if (isGrowing)
        {
            // If the size is greater than the maximum size, reduce it
            if (currentSize > maxSize)
            {
                isGrowing = false;
            }
        }
        else
        {
            // If the size is smaller than the maximum size, increase it
            if (currentSize < minSize)
            {
                isGrowing = true;
            }
        }

        // Changing the size of the object according to the set speed
        float newSize = currentSize + (isGrowing ? growthSpeed : -growthSpeed) * Time.deltaTime;
        transform.localScale = new Vector3(newSize, newSize, newSize);
    }
}
