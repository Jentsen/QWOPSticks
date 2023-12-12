using System.Collections;
using UnityEngine;

public class chopsickControlAlt : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float downSpeed = 3f;
    public float upSpeed = 3f;
    public float rotationSpeed = 100f;
    public float originalYPosition = 11f;

    private bool isMovingDown = false;

    void FixedUpdate()
    {
        // Movement Controls
        // Move chopsticks left or right with left shift and right shift
        float horizontalInput = 0;
        if (Input.GetKey(KeyCode.LeftShift))
        {
            horizontalInput = -1;
        }
        else if (Input.GetKey(KeyCode.RightShift))
        {
            horizontalInput = 1;
        }

        // Rotate chopsticks1 clockwise when pressing Q and counterclockwise when pressing W
        if (Input.GetKey(KeyCode.Q))
        {
            RotateClockwise("Chopstick1");
        }
        else if (Input.GetKey(KeyCode.W))
        {
            RotateCounterClockwise("Chopstick1");
        }

        // Rotate chopsticks2 clockwise when pressing O and counter clockwise when pressing P
        if (Input.GetKey(KeyCode.O))
        {
            RotateClockwise("Chopstick2");
        }
        else if (Input.GetKey(KeyCode.P))
        {
            RotateCounterClockwise("Chopstick2");
        }

        Vector3 horizontalMovement = new Vector3(horizontalInput, 0, 0);
        transform.Translate(horizontalMovement * Time.deltaTime * moveSpeed);

        // Move chopsticks down when the down arrow key is pressed
        if (Input.GetKey(KeyCode.Space))
        {
            isMovingDown = true;
            Vector3 downMovement = new Vector3(0, -1, 0);
            transform.Translate(downMovement * Time.deltaTime * downSpeed);
        }
        else if (isMovingDown)
        {
            // If the down arrow key is released, start the coroutine to return to the original Y position
            isMovingDown = false;
            StartCoroutine(ReturnToOriginalPosition());
        }
    }

    void RotateClockwise(string chopstickName)
    {
        GameObject chopstick = GameObject.Find(chopstickName);
        chopstick.transform.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime);
    }

    void RotateCounterClockwise(string chopstickName)
    {
        GameObject chopstick = GameObject.Find(chopstickName);
        chopstick.transform.Rotate(Vector3.forward * -rotationSpeed * Time.deltaTime);
    }

    IEnumerator ReturnToOriginalPosition()
    {
        while (transform.position.y < originalYPosition)
        {
            transform.Translate(Vector3.up * Time.deltaTime * upSpeed);
            yield return null;
        }

        transform.position = new Vector3(transform.position.x, originalYPosition, transform.position.z);
    }
}
