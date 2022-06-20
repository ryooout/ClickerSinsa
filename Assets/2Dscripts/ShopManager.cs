using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ShopManager : MonoBehaviour
{
    [SerializeField] GameManager gameManager = default;
    [SerializeField] ScoreAdd scoreAdd = default;
    [SerializeField] AutoAdd autoAdd = default;
    /// <summary>アイテムボタン一覧</summary>
    public Button[] shopButton = default;
    /// <summary>shopのopen,close</summary>
    [SerializeField] GameObject[] shopOpen = default;
    [SerializeField] GameObject AddObj = default;
    /// <summary>購入回数</summary>
    [SerializeField] Text[] itemBuyCount = default;
    /// <summary>杖</summary>
    public float cane = 10;
    /// <summary>車いす</summary>
    public float wheelchair = 100;
    /// <summary>サプリ</summary>
    public float supplement = 1000;
    /// <summary>お金</summary>
    public float money = 5000;
    public GameObject[] itemPrefab = default;
    public int count = 0;
    public int count1 = 0;
    public int count2 = 0;
    public int count3 = 0;
     /// <summary>値段上昇 </summary>
    float increse = 1.13f;
    float increse1 = 1.05f;
    float increse2 = 1.02f;
    float increse3 = 1.015f;
    /// <summary>値自動加算</summary>
    public float auto = 1;
    public float auto1 = 1;
    public float auto2 = 1;
    public float auto3 = 1;
    float x;
    float y;
    private void Awake()
    {
       AddObj.SetActive(false);
        shopOpen[0].SetActive(true);//ショップオープン
        shopOpen[1].SetActive(false);//ショップクローズ
        shopOpen[2].SetActive(false);//ショップアイテム一覧
    }
    void Start()
    {
        Generate();
    }
    void Update()
    {
        ItemShopColor();
        BuyCount();
        x = Random.Range(-10, 10);
        y = Random.Range(-4, 4);
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
    public void Generate()
    {
        //・AddListener...スクリプトからボタンのイベントを呼び出すことが出来る
        shopButton[0].onClick.AddListener(() =>
        {　　　　　　　　　　　　　　　　　//値が低かったら戻り値を返す
            if (gameManager.score < cane) return;
            count++;
            AddObj.SetActive(true);
            gameManager.score -= Mathf.FloorToInt(cane);
            cane += Mathf.FloorToInt(cane*increse);
            autoAdd.number += Mathf.FloorToInt(1 * auto);
            scoreAdd.increse +=  0.05f;
            scoreAdd.increse1 += 0.05f;
            scoreAdd.increse2 += 0.05f;
            scoreAdd.increse3 += 0.05f;
            scoreAdd.increse4 += 0.05f;
            /*Instantiate(itemPrefab[0],new Vector2(x0,y0),Quaternion.identity);
            if (x0 >= 12.0f)
            { x0 = -11; }
            x0 += 0.15f;*/
            if (count % 5 == 0)
            {
                Instantiate(itemPrefab[0], new Vector2(x, y), Quaternion.identity);
            }
        });
        shopButton[1].onClick.AddListener(() =>
        {
            if (gameManager.score < wheelchair) return;
            count1++;
            AddObj.SetActive(true);
            gameManager.score -= Mathf.FloorToInt(wheelchair);
            wheelchair += Mathf.FloorToInt(wheelchair * increse1);
            autoAdd.number += Mathf.FloorToInt(3 * auto1);
            scoreAdd.increse  += 0.08f;
            scoreAdd.increse1 += 0.08f;
            scoreAdd.increse2 += 0.08f;
            scoreAdd.increse3 += 0.08f;
            scoreAdd.increse4 += 0.08f;
            /*Instantiate(itemPrefab[1], new Vector2(x1, y1), Quaternion.identity);
            if (x1 >= 12.0f)
            { x1 = -11; }
            x1 += 0.3f;*/
            if (count1 % 5 == 0)
            {
                Instantiate(itemPrefab[1], new Vector2(x, y), Quaternion.identity);
            }
        });
        shopButton[2].onClick.AddListener(() =>
        {
            if (gameManager.score < supplement) return;
            count2++;
            AddObj.SetActive(true);
            gameManager.score -= Mathf.FloorToInt(supplement);
            supplement += Mathf.FloorToInt(supplement * increse2);
            autoAdd.number += Mathf.FloorToInt(5 * auto2);
            gameManager.delete += 0.11f;
            scoreAdd.increse +=  0.11f;
            scoreAdd.increse1 += 0.11f;
            scoreAdd.increse2 += 0.11f;
            scoreAdd.increse3 += 0.11f;
            scoreAdd.increse4 += 0.11f;
            if (count2 % 5 == 0)
            {
                Instantiate(itemPrefab[2], new Vector2(x, y), Quaternion.identity);
            }
            /*Instantiate(itemPrefab[2], new Vector2(x2, y2), Quaternion.identity);
            if (x2 >= 12.0f)
            { x2 = -11; }
            x2 += 0.3f;*/
        });
        shopButton[3].onClick.AddListener(() =>
        {
            if (gameManager.score < money) return;
            count3++;
            AddObj.SetActive(true);
            gameManager.score -= Mathf.FloorToInt(money);
            money += Mathf.FloorToInt(money * increse3);
            autoAdd.number += Mathf.FloorToInt(15 * auto3);
            gameManager.delete += 0.7f;
            gameManager.AddScore(350);
            scoreAdd.increse +=  0.13f;
            scoreAdd.increse1 += 0.13f;
            scoreAdd.increse2 += 0.13f;
            scoreAdd.increse3 += 0.13f;
            scoreAdd.increse4 += 0.13f;
            /*Instantiate(itemPrefab[3], new Vector2(x3, y3), Quaternion.identity);           
            if(x3 >= 12.0f)
            { x3 = -11; }
            x3 += 0.3f;*/
            if (count3 % 5 == 0)
            {
                Instantiate(itemPrefab[3], new Vector2(x, y), Quaternion.identity);
            }
        });
    }
    public void BuyCount()
    {
        itemBuyCount[0].text = "購入回数:" + count.ToString() + "回";
        itemBuyCount[1].text = "購入回数:" + count1.ToString() + "回";
        itemBuyCount[2].text = "購入回数:" + count2.ToString() + "回";
        itemBuyCount[3].text = "購入回数:" + count3.ToString() + "回";
    }   
}
