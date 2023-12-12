using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathBorder : MonoBehaviour
{

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag != "Chopsticks")
        {
            Destroy(other.gameObject);
        }
    }
}
