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
    public float supplement = 1000;
    /// <summary>お金</summary>
    public float money = 5000;
    public GameObject[] itemPrefab = default;
    public int count = 0;
    public int count1 = 0;
    public int count2 = 0;
    public int count3 = 0;
     /// <summary>値段上昇 </summary>
    float increse = 1;
    float increse1 = 1;
    float increse2 = 1;
    float increse3 = 0;
    /// <summary>値自動加算</summary>
    float auto = 1;
    float auto1 = 1;
    float auto2 = 1;
    float auto3 = 1;

    private void Awake()
    {
       AddObj.SetActive(false);
        shopOpen[0].SetActive(true);//ショップオープン
        shopOpen[1].SetActive(false);//ショップクローズ
        shopOpen[2].SetActive(false);//ショップアイテム一覧
        itemBuyCount[0].text = "購入回数:" + count.ToString() + "回";
        itemBuyCount[1].text = "購入回数:" + count1.ToString() + "回";
        itemBuyCount[2].text = "購入回数:" + count2.ToString() + "回";
        itemBuyCount[3].text = "購入回数:" + count3.ToString() + "回";
    }
    void Start()
    {
        //・AddListener...スクリプトからボタンのイベントを呼び出すことが出来る
        shopButton[0].onClick.AddListener(() =>
        {　　　　　　　　　　　　　　　　　//値を返す
            if (gameManager.score < cane) return;
            count++;
            itemBuyCount[0].text ="購入回数:"+ count.ToString()+"回";
            AddObj.SetActive(true);
            gameManager.score -= Mathf.FloorToInt(cane*increse);
            increse = 1.13f;
            cane += Mathf.FloorToInt(cane*increse);
            autoAdd.number+=Mathf.FloorToInt(1*auto);
            /*Instantiate(itemPrefab[0],new Vector2(x0,y0),Quaternion.identity);
            if (x0 >= 12.0f)
            { x0 = -11; }
            x0 += 0.15f;*/
            if(count%5 ==0)
            {
            }
        });
        shopButton[1].onClick.AddListener(() =>
        {　　　　　　　　　　
            if (gameManager.score < wheelchair) return;
            count1++;
            itemBuyCount[1].text = "購入回数:"+count1.ToString() + "回";
            AddObj.SetActive(true);
            gameManager.score -= Mathf.FloorToInt(wheelchair*increse1);
            increse1 = 1.05f;
            wheelchair += Mathf.FloorToInt(wheelchair * increse1);            
            autoAdd.number += Mathf.FloorToInt(3*auto1);
            /*Instantiate(itemPrefab[1], new Vector2(x1, y1), Quaternion.identity);
            if (x1 >= 12.0f)
            { x1 = -11; }
            x1 += 0.3f;*/
            if (count1 % 5 == 0)
            {
            }
        });
        shopButton[2].onClick.AddListener(() =>
        {                                        
            if (gameManager.score < supplement) return;
            count2++;
            itemBuyCount[2].text = "購入回数:" + count2.ToString() + "回";
            AddObj.SetActive(true);
            gameManager.score -= Mathf.FloorToInt(supplement*increse2);
            increse2 = 1.02f;
            supplement += Mathf.FloorToInt(supplement*increse2);
            autoAdd.number += Mathf.FloorToInt(5*auto2);
            gameManager.delete += 0.05f;
            if (count2 % 5 == 0)
            {
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
            itemBuyCount[3].text = "購入回数:" + count3.ToString() + "回";
            AddObj.SetActive(true);
            gameManager.score -= Mathf.FloorToInt(money * increse3);
            increse3 = 1.015f;
            money += Mathf.FloorToInt(money * increse3);
            autoAdd.number += Mathf.FloorToInt(15*auto3);
            gameManager.delete += 0.7f;
            gameManager.AddScore(350);
            /*Instantiate(itemPrefab[3], new Vector2(x3, y3), Quaternion.identity);           
            if(x3 >= 12.0f)
            { x3 = -11; }
            x3 += 0.3f;*/
            if (count3 % 5 == 0)
            {
            }
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
