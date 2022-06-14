using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GatyaTimeText : MonoBehaviour
{
    [SerializeField]GatyaManager gatyaManager;
    float time = 10.0f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        time-=Time.deltaTime;
        if (time >= 0)
        { gatyaManager.gatyaTimer.text = "ƒdƒ‰I—¹‚Ü‚Åc‚è:" + time.ToString("F2") + "•b"; }
        else
        {
            time = 10.0f;
        }
    }
}
