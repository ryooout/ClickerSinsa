using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public int score = 0;
    void Start()
    {       
    }

    // Update is called once per frame
    void Update()
    {   
    }
    public void AddScore(int addScore)
    {
        score += addScore;
    }
}
