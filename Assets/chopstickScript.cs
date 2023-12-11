using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using Debug = UnityEngine.Debug;

public class chopstickScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public string tagToAdd;

    //private void OnCollisionEnter2D(Collision2D col)
    //{
    //    Debug.Log(col.gameObject.name);
        // creates joint
    //    FixedJoint2D joint = gameObject.AddComponent<FixedJoint2D>();
        // sets joint position to point of contact
    //    joint.anchor = col.contacts[0].point;
        // conects the joint to the other object
    //    joint.connectedBody = col.contacts[0].otherCollider.transform.GetComponentInParent<Rigidbody2D>();
        // Stops objects from continuing to collide and creating more joints
    //    joint.enableCollision = false;
    //}

public class ConnectOnCollision2D : MonoBehaviour
{
    // Reference to the other object to connect
    public GameObject otherObject;

    // Variable to check if the objects are already connected
    private bool isConnected = false;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Check if the collision is with the specified other object and not already connected
        if (collision.gameObject == otherObject && !isConnected)
        {
            // Add a FixedJoint2D component
            FixedJoint2D joint = gameObject.AddComponent<FixedJoint2D>();

            // Connect the joint to the other object's Rigidbody2D
            joint.connectedBody = otherObject.GetComponent<Rigidbody2D>();

            // Set isConnected to true to prevent further joints from being created
            isConnected = true;
        }
    }
}


}
