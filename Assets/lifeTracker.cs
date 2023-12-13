using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;
//using System.Diagnostics;
using Debug = UnityEngine.Debug;

public class lifeTracker : MonoBehaviour
{

    public TMP_Text life;
    public TMP_Text score;
    public DeathBorder deathBorder;
    public scoreDetectScript scoreDet;
    public GameObject endCanvas;
    public int lifeCount = 3;
    public int scoreCount = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(lifeCount == 0)
        {
            endCanvas.SetActive(true);
        }
        //lifeCount = DeathBorder.GetComponents<DeathBorder>().Lives;
        lifeCount = deathBorder.Lives;
        scoreCount = scoreDet.score;
        //Debug.Log(deathBorder.Lives);
        // playtime.text = string.Format("{0:00}:{1:00}", minutes, seconds);
        life.text = string.Format("Lives: {0}", lifeCount);
        score.text = string.Format("Score: {0}", scoreCount);
    }
}
