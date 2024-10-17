using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ReticleMovement : MonoBehaviour
{
    public Transform reticle; // Assign your reticle GameObject here
    public float speed = 2.0f; // Speed of the reticle movement
    public Vector2 movementRange = new Vector2(0.5f, 0.5f); // Range for movement

    private Vector3 startPosition;

    void Start()
    {
        // Store the initial position of the reticle
        startPosition = reticle.position;
    }

    void Update()
    {
        // Calculate new position based on sine wave for smooth movement
        float newX = startPosition.x + Mathf.Sin(Time.time * speed) * movementRange.x;
        float newY = startPosition.y + Mathf.Cos(Time.time * speed) * movementRange.y;

        // Update reticle position
        reticle.position = new Vector3(newX, newY, startPosition.z);
    }
}

