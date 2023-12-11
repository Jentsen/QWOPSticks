using System.Diagnostics;
using UnityEngine;
using Debug = UnityEngine.Debug;

public class MouseInteraction : MonoBehaviour
{
    void Update()
    {
        // Check if the player has clicked the mouse
        if (Input.GetMouseButtonDown(0))
        {
            // Cast a ray from the camera to the mouse position
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            // Check if the ray hits any colliders
            if (Physics.Raycast(ray, out hit))
            {
                // Get the GameObject that was hit
                GameObject clickedObject = hit.collider.gameObject;

                // Perform actions based on the clickedObject
                Debug.Log("Clicked on: " + clickedObject.name);

                // Example: If the clicked object has a script, you can call a method
                
            }
        }
    }
}