using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideObject : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    private bool isVisible = true;

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();

        if (spriteRenderer == null) // if the object doesn't contain the sprite renderer component, return error.
        {
            Debug.LogError("SpriteRenderer component not found on the object!");
        }
    }

    private void Update()
    {
        // Checking if the confirm button was pressed
        if (Input.GetButtonDown("Fire1")) 
        {
            // Hide or show the object accordingly
            ToggleVisibilityState();
        }
    }

    void ToggleVisibilityState()
    {
        // Hide or show the object accordingly
        isVisible = !isVisible;

        if (spriteRenderer != null)
        {
            spriteRenderer.enabled = isVisible;
        }
        else
        {
            Debug.LogError("SpriteRenderer component not found!");
        }
    }
}


