using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform playerTransform;  // Reference to the player's transform
    public float mouseSensitivity = 2.0f;

    private float verticalRotation = 0f;

    void Update()
    {
        if (playerTransform == null)
        {
            Debug.LogWarning("Player transform is not set for the first-person camera!");
            return;
        }

        // Capture mouse input for rotation
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity;

        // Rotate the player horizontally
        playerTransform.Rotate(Vector3.up * mouseX);

        // Rotate the camera vertically (limited to prevent over-rotation)
        verticalRotation -= mouseY;
        verticalRotation = Mathf.Clamp(verticalRotation, -90f, 90f);
        transform.localRotation = Quaternion.Euler(verticalRotation, 0, 0);
    }
}

