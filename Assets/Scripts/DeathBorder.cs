using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathBorder : MonoBehaviour
{

    public int Lives = 3;

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag != "Chopsticks")
        {
            Destroy(other.gameObject);
            Lives--;
        }
    }
}
