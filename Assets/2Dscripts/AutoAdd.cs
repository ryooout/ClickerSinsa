using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoAdd : MonoBehaviour
{
    [SerializeField]GameManager gameManager = default;
    float time = 0;
    float span = 1.0f;
   public int number = 0;
    public int gatyaNumber = 0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        AddAuto();
        GatyaAdd();
    }
    /// <summary>�V���b�v�ɂ�鎩�����Z</summary>
    public void AddAuto()
    {
        time+=Time.deltaTime;
        if(time>span)
        {
           gameManager.score += number; 
            time=0;
        }
    }
    /// <summary>�K�`���ɂ�鎩�����Z</summary>
    public void GatyaAdd()
    {
        time += Time.deltaTime;
        if (time > span)
        {
            gameManager.score += gatyaNumber;
            time = 0;
        }
    }
}
