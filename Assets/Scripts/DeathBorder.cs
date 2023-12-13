using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathBorder : MonoBehaviour
{

    public int Lives = 3;
    public ParticleSystem loseEffect;

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag != "Chopsticks")
        {
            GameObject.Instantiate(loseEffect, transform.position, transform.rotation);
            Destroy(other.gameObject);
            Lives--;
        }
    }
}
