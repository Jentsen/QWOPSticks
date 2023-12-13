using System.Collections;
using System.Collections.Generic;
//using System.Diagnostics;
using UnityEngine;

public class scoreDetectScript : MonoBehaviour
{
    public int score = 0;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "objects")
        {
            
            score++;
            Debug.Log(score);
        }
    }
}
