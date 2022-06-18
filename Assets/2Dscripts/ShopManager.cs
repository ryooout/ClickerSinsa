using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ShopManager : MonoBehaviour
{
    [SerializeField] GameManager gameManager = default;
    [SerializeField] AutoAdd autoAdd = default;
    /// <summary>アイテムボタン一覧</summary>
    [SerializeField] Button[] shopButton = default;
    /// <summary>shopのopen,close</summary>
    [SerializeField] GameObject[]shopOpen = default;
    [SerializeField] GameObject AddObj = default;
    /// <summary>杖</summary>
    public int cane = 50;
    /// <summary>車いす</summary>
    public int wheelchair = 150;
    /// <summary>サプリ</summary>
    public int supplement = 300;
    /// <summary>お金</summary>
    public int money = 500;
    private void Awake()
    {
       AddObj.SetActive(false);
        shopOpen[0].SetActive(true);//ショップオープン
        shopOpen[1].SetActive(false);//ショップクローズ
        shopOpen[2].SetActive(false);//ショップアイテム一覧
    }
    void Start()
    {
        //・AddListener...スクリプトからボタンのイベントを呼び出すことが出来る
        shopButton[0].onClick.AddListener(() =>
        {　　　　　　　　　　　　　　　　　//値を返す
            if (gameManager.score < cane) return;
            AddObj.SetActive(true);
            gameManager.score -= cane;
            cane += 13;
            autoAdd.number++;
            
        });
        shopButton[1].onClick.AddListener(() =>
        {　　　　　　　　　　　　　　　　　　　
            if (gameManager.score < wheelchair) return;
            AddObj.SetActive(true);
            gameManager.score -= wheelchair;
            wheelchair += 33;
            autoAdd.number += 3;
        });
        shopButton[2].onClick.AddListener(() =>
        {                                        
            if (gameManager.score < supplement) return;
            AddObj.SetActive(true);
            gameManager.score -= supplement;
            supplement += 63;
            autoAdd.number += 5;
            gameManager.delete += 0.05f;
        });
        shopButton[3].onClick.AddListener(() =>
        {
            if (gameManager.score < money) return;
            AddObj.SetActive(true);
            gameManager.score -= money;
            money += 103;
            autoAdd.number += 15;
            gameManager.AddScore(200);
            gameManager.delete += 0.2f;
        });
    }
    void Update()
    {
        ItemShopColor();
    }
    /// <summary>値によって色が変わる</summary>
    public void ItemShopColor()
    {
        if (gameManager.score >= cane)
        {gameManager.shopText[0].color = Color.black;}
        else
        {gameManager.shopText[0].color = Color.red;}

        if (gameManager.score >= wheelchair)
        {gameManager.shopText[1].color = Color.black;}
        else
        {gameManager.shopText[1].color = Color.red;}

        if (gameManager.score >= supplement)
        {gameManager.shopText[2].color = Color.black;}
        else
        {gameManager.shopText[2].color = Color.red;}

        if (gameManager.score >= money)
        {gameManager.shopText[3].color = Color.black;}
            else
            {gameManager.shopText[3].color = Color.red;}
    }
}
