using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathBorder : MonoBehaviour
{
    public GameObject deathBorderPrefab;

    void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
    }
}
