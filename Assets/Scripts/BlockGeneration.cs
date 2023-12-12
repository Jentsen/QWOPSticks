using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockGeneration : MonoBehaviour
{
    public GameObject blockPrefab;
    
    void Update()
    {
        // Generate a block when the enter key is pressed
        if (Input.GetKeyDown(KeyCode.Return))
        {
            Instantiate(blockPrefab, transform.position, Quaternion.identity);
        }
    }
}
