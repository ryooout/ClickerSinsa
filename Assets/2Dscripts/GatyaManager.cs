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
    /// <summary>ガチャから出るもの</summary>
    [SerializeField]GameObject[]katuraPrefab = default;
    /// <summary>ガチャ操作のボタン</summary>
    [SerializeField] Button[] gatyaButton = default;
    /// <summary>効果時間</summary>
    public Text gatyaTimer = default;
    /// <summary>ガチャ結果</summary>
    [SerializeField] Text[]gatyaResultText = default;
    [SerializeField] Text notRotate = default;
    /// <summary>ガチャの値段表示 </summary>
    [SerializeField] Text gatyaPriceText = default;
    int i;
    int i0 = 20;
    int i1 = 40;
    int i2 = 60;
    int i3 = 80;
    public int gatyaPrice = 1000;
    GameObject katura = default;
    GameObject timerObj = default;
    private void Awake()
    {
        gatyaResultText[0].gameObject.SetActive(false);
        gatyaResultText[1].gameObject.SetActive(false);
        gatyaResultText[2].gameObject.SetActive(false);
        gatyaResultText[3].gameObject.SetActive(false);
    }
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
        gatyaPriceText.text = "       " + "ガチャ\n親密度" + gatyaPrice + "爺";
    }
    public void GatyaClick()
    { 
        if (gameManager.score >= 1000&&!timerObj.activeSelf)
        {
            gatyaTimer.gameObject.SetActive(true);
            notRotate.gameObject.SetActive(false);
            gatyaPrefab.GetComponent<Renderer>().material.color = Color.magenta;
           katura = Instantiate(katuraPrefab[i], new Vector2(0, 3), Quaternion.identity);
            gameManager.score -= gatyaPrice;
            gatyaPrice += 100;
            if (timerObj.activeSelf)
            {
                autoObj.SetActive(true);
                if (i==0)//black
                {
                    autoAdd.gatyaNumber += i0;
                    Debug.Log(autoAdd.gatyaNumber += i0);
                    gameManager.span = 0.7f;
                    gatyaResultText[0].gameObject.SetActive(true);
                }
                else if (i == 1)//gold
                {
                    autoAdd.gatyaNumber += i1;
                    Debug.Log(autoAdd.gatyaNumber += i1);
                    gameManager.span = 0.8f;
                    gatyaResultText[1].gameObject.SetActive(true);
                }
                else if (i == 2)//short
                { 
                    autoAdd.gatyaNumber += i2;
                    Debug.Log(autoAdd.gatyaNumber += i2);
                    gameManager.span = 0.9f;
                    gatyaResultText[2].gameObject.SetActive(true);
                }
                else if(i == 3)//short2
                {
                    autoAdd.gatyaNumber += i3;
                    Debug.Log(autoAdd.gatyaNumber += i3);
                    gameManager.span = 1.0f;
                    gatyaResultText[3].gameObject.SetActive(true);
                }
                Invoke(nameof(Generater), 10.0f);
            }
        }        
        else if(gameManager.score < 1000||timerObj.activeSelf)
        {
            notRotate.gameObject.SetActive(true);
            gatyaPrefab.GetComponent<Renderer>().material.color = Color.red;
            Invoke(nameof(NotRotate), 2.0f);
            gameManager.span = 1.5f;
        }
       
    }
   public void Generater()
    {
        katura.SetActive(false);
        gatyaTimer.gameObject.SetActive(false);
        gatyaPrefab.GetComponent<Renderer>().material.color = Color.white;
        gatyaResultText[0].gameObject.SetActive(false);
        gatyaResultText[1].gameObject.SetActive(false);
        gatyaResultText[2].gameObject.SetActive(false);
        gatyaResultText[3].gameObject.SetActive(false);
        if (i == 0)
        {
            autoAdd.gatyaNumber = 0;
            gameManager.span = 1.5f;
        }
        else if (i == 1)
        {
            autoAdd.gatyaNumber = 0;
            gameManager.span = 1.5f;          
        }
        else if (i == 2)
        {
            autoAdd.gatyaNumber = 0;
            gameManager.span = 1.5f;          
        }
        else if (i == 3)
        {
            autoAdd.gatyaNumber = 0;
            gameManager.span = 1.5f;         
        }
    }
    void NotRotate()
    {
        notRotate.gameObject.SetActive(false);
        gatyaPrefab.GetComponent<Renderer>().material.color = Color.white;
    }
}
