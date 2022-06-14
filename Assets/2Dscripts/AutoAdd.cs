using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoAdd : MonoBehaviour
{
    [SerializeField]GameManager gameManager = default;
    float time;
    float span = 1.0f;
   public int number = 0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        AddAuto();
    }
    public void AddAuto()
    {
        time+=Time.deltaTime;
        if(time>span)
        {
           gameManager.score += number; 
            time=0;
        }
    }
}
