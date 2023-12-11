using System.Collections;
using UnityEngine;

public class ChopsticksControls : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float downSpeed = 3f;
    public float returnSpeed = 2.5f; // Adjust the return speed as needed
    public float originalYPosition = 11f;

    private Animator chopstick1Animator;
    private Animator chopstick2Animator;

    private bool isMovingDown = false;

    void Start()
    {
        // Get the Animator components from the child objects
        chopstick1Animator = transform.Find("Chopstick1").GetComponent<Animator>();
        chopstick2Animator = transform.Find("Chopstick2").GetComponent<Animator>();
    }

    void Update()
    {
        // Move chopsticks left or right
        float horizontalInput = Input.GetAxisRaw("Horizontal");
        Vector3 horizontalMovement = new Vector3(horizontalInput, 0, 0);
        transform.Translate(horizontalMovement * Time.deltaTime * moveSpeed);

        // Move chopsticks down when the down arrow key is pressed
        if (Input.GetKey(KeyCode.DownArrow))
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

        // Play the chopsticks close animation when the space bar is pressed
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Trigger animations for both chopsticks
            chopstick1Animator.SetTrigger("chopstick1Close");
            chopstick2Animator.SetTrigger("chopstick2Close");
        }
    }

    IEnumerator ReturnToOriginalPosition()
    {
        while (transform.position.y < originalYPosition)
        {
            transform.Translate(Vector3.up * Time.deltaTime * returnSpeed);
            yield return null;
        }

        transform.position = new Vector3(transform.position.x, originalYPosition, transform.position.z);
    }

}
