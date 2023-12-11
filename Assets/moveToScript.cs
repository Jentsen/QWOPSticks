using System.Collections;
using System.Collections.Generic;
//using System.Diagnostics;
using UnityEngine;

public class moveToScript : MonoBehaviour
{
    // Start is called before the first frame update

    // Reference to the target object whose position we want to reach
    public Transform targetObject;

    // Speed of the movement
    public float moveSpeed = 5f;

    void Start()
    {

    }

    void Update()
    {
        // Check if the target object is assigned
        if (targetObject != null)
        {
            // Calculate the new position based on the target object's position
            Vector2 targetPosition = new Vector2(targetObject.position.x, targetObject.position.y);

            // Smoothly move towards the target position
            transform.position = Vector2.Lerp(transform.position, targetPosition, moveSpeed * Time.deltaTime);
        }
        else
        {
            Debug.LogWarning("Target object not assigned. Please assign a target object in the Inspector.");
        }
    }
}
