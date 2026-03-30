using System;
using NUnit.Framework.Internal;
using UnityEditor.Callbacks;
using UnityEngine;
using UnityEngine.InputSystem;

public class destroy : MonoBehaviour
{

    public GameObject Planeyer;
    private Renderer objectRenderer;

    void Start()
    {
        // Get the renderer component attached to this object
        objectRenderer = GetComponent<Renderer>();
    }

    void Update()
    {
        // Check for Right Click Press
        if (Mouse.current.rightButton.wasPressedThisFrame)
        {
            objectRenderer.enabled = false; // Makes it invisible
        }

        // Check for Right Click Release
        if (Mouse.current.rightButton.wasReleasedThisFrame)
        {
            objectRenderer.enabled = true; // Makes it visible again
        }
    }
}
