using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ShopManager : MonoBehaviour
{
    [SerializeField] GameManager gameManager = default;
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
    public float supplement = 900;
    /// <summary>お金</summary>
    public float money = 2000;
    public GameObject[] itemPrefab = default;
    public int levelCount = 0;
    public int levelCount1 = 0;
    public int levelCount2 = 0;
    public int levelCount3 = 0;
     /// <summary>値段上昇 </summary>
    public float increse =  1;
    public float increse1 = 1;
    public float increse2 = 1;
    public float increse3 = 1;
    /// <summary>値自動加算</summary>
    public float auto = 1;
    public float auto1 = 1;
    public float auto2 = 1;
    public float auto3 = 1;
    float x;
    float y;
    /// <summary>おじさんをクリックしたときの値上昇 </summary>
    public float inc = 1;
    public float inc1 = 1;
    public float inc2 = 1;
    public float inc3 = 1;
    public float inc4 = 1;
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
            levelCount++;
            AddObj.SetActive(true);
            increse *= 1.23f;
            gameManager.score -= Mathf.FloorToInt(cane);
            cane += Mathf.FloorToInt(cane*increse);
            autoAdd.number += Mathf.FloorToInt((1 * auto)+1);
            inc  += 2.4f;
            inc1 += 3.5f;
            inc2 += 4.1f;
            inc3 += 5.2f;
            inc4 += 1.95f;
            /*Instantiate(itemPrefab[0],new Vector2(x0,y0),Quaternion.identity);
            if (x0 >= 12.0f)
            { x0 = -11; }
            x0 += 0.15f;*/
            if (levelCount % 5 == 0)
            {
                Instantiate(itemPrefab[0], new Vector2(x, y), Quaternion.identity);
            }
        });
        shopButton[1].onClick.AddListener(() =>
        {
            if (gameManager.score < wheelchair) return;
            levelCount1++;
            AddObj.SetActive(true);
            increse1 *= 1.23f;
            gameManager.score -= Mathf.FloorToInt(wheelchair);
            wheelchair += Mathf.FloorToInt(wheelchair * increse1);
            autoAdd.number += Mathf.FloorToInt((3 * auto1)+2);
            inc += 2.7f;
            inc1 += 3.8f;
            inc2 += 4.9f;
            inc3 += 6.0f;
            inc4 += 2.0f;
            /*Instantiate(itemPrefab[1], new Vector2(x1, y1), Quaternion.identity);
            if (x1 >= 12.0f)
            { x1 = -11; }
            x1 += 0.3f;*/
            if (levelCount1 % 5 == 0)
            {
                Instantiate(itemPrefab[1], new Vector2(x, y), Quaternion.identity);
            }
        });
        shopButton[2].onClick.AddListener(() =>
        {
            if (gameManager.score < supplement) return;
            levelCount2++;
            AddObj.SetActive(true);
            increse2 *= 1.23f;
            gameManager.score -= Mathf.FloorToInt(supplement);
            supplement += Mathf.FloorToInt(supplement * increse2);            
            autoAdd.number += Mathf.FloorToInt((5 * auto2)+3);
            gameManager.delete += 0.3f;
            inc += 3.5f;
            inc1 += 5.4f;
            inc2 += 7.5f;
            inc3 += 8.2f;
            inc4 += 2.15f;
            if (levelCount2 % 5 == 0)
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
            levelCount3++;
            AddObj.SetActive(true);
            increse3 *= 1.23f;
            gameManager.score -= Mathf.FloorToInt(money);
            money += Mathf.FloorToInt(money * increse3); 
            autoAdd.number += Mathf.FloorToInt((15 * auto3)+4);
            gameManager.delete += 0.7f;
            gameManager.AddScore(350);
            inc += 5.3f;
            inc1 += 7.4f;
            inc2 += 9.5f;
            inc3 += 11.4f;
            inc4 += 2.25f;
            /*Instantiate(itemPrefab[3], new Vector2(x3, y3), Quaternion.identity);           
            if(x3 >= 12.0f)
            { x3 = -11; }
            x3 += 0.3f;*/
            if (levelCount3 % 5 == 0)
            {
                Instantiate(itemPrefab[3], new Vector2(x, y), Quaternion.identity);
            }
        });
    }
    public void BuyCount()
    {
        itemBuyCount[0].text = "レベル:" + levelCount.ToString();
        itemBuyCount[1].text = "レベル:" + levelCount1.ToString();
        itemBuyCount[2].text = "レベル:" + levelCount2.ToString();
        itemBuyCount[3].text = "レベル:" + levelCount3.ToString();
    }   
}
