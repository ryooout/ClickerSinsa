using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GatyaManager : MonoBehaviour
{
    [SerializeField]GameManager gameManager = default;
    [SerializeField] AutoAdd autoAdd = default;
    [SerializeField] GameObject autoObj = default;
    [SerializeField]GameObject  gatyaPrefab = default;
    [SerializeField]GameObject[]katuraPrefab = default;
    [SerializeField] Button[] gatyaButton = default;
    public Text gatyaTimer = default;
    [SerializeField] Text notRotate = default;
    int i;
    int i0 = 20;
    int i1 = 40;
    int i2 = 60;
    int i3 = 80;
    GameObject katura;
    GameObject timerObj;
    void Start()
    {
        timerObj = GameObject.Find("GatyaTimer");
        notRotate.gameObject.SetActive(false);
        gatyaButton[0].gameObject.SetActive(true);
        gatyaButton[1].gameObject.SetActive(false);
        gatyaTimer.gameObject.SetActive(false);
        gatyaPrefab.SetActive(false); 
    }

    // Update is called once per frame
    void Update()
    {
        i = Random.Range(0, katuraPrefab.Length);
    }
    public void OnClick()
    {
        gatyaPrefab.SetActive(true);
        gatyaButton[0].gameObject.SetActive(false);
        gatyaButton[1].gameObject.SetActive(true);
    }
    public void Close()
    {
        gatyaPrefab.SetActive(false);
        gatyaButton[0].gameObject.SetActive(true);
        gatyaButton[1].gameObject.SetActive(false);
        if(notRotate)
        {
            notRotate.gameObject.SetActive(false);
        }
    }
    public void GatyaClick()
    { 
        if (gameManager.score >= 1000&&!timerObj.activeSelf)
        {
            gatyaTimer.gameObject.SetActive(true);
            notRotate.gameObject.SetActive(false);
            gatyaPrefab.GetComponent<Renderer>().material.color = Color.magenta;
           katura = Instantiate(katuraPrefab[i], new Vector2(0, 3), Quaternion.identity);
            gameManager.score -= 1000;
            Invoke(nameof(Generater), 10.0f);
            if (timerObj.activeSelf)
            {
                autoObj.SetActive(true);
                if (i==0)//black
                {
                    autoAdd.number += i0;
                    gameManager.span = 0.7f;
                }
                else if (i == 1)//katura
                {
                    autoAdd.number += i1;
                    gameManager.span = 0.8f;
                }
                else if (i == 2)//short
                { 
                    autoAdd.number += i2;
                    gameManager.span = 0.9f;
                }
                else if(i == 3)//short2
                {
                    autoAdd.number += i3;
                    gameManager.span = 1.0f;
                }
            }
        }        
        else if(gameManager.score < 1000||timerObj.activeSelf)
        {
            notRotate.gameObject.SetActive(true);
            Invoke(nameof(NotRotate), 2.0f);
            gatyaPrefab.GetComponent<Renderer>().material.color = Color.red;
        }
    }
   public void Generater()
    {
        katura.SetActive(false);
        gatyaTimer.gameObject.SetActive(false);
        gatyaPrefab.GetComponent<Renderer>().material.color = Color.white;
        if (i == 0)
        {
            autoAdd.number -= i0;
        }
        else if (i == 1)
        {
            autoAdd.number -= i1;
        }
        else if (i == 2)
        {
            autoAdd.number -= i2;
        }
        else if (i == 3)
        {
            autoAdd.number -= i3;
        }
    }
    void NotRotate()
    {
        notRotate.gameObject.SetActive(false);
    }
}
