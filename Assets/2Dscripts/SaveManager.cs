
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using UnityEngine;

public class SaveManager : MonoBehaviour
{
    [SerializeField]GameManager gameManager = default;
    [SerializeField] AutoAdd autoAdd = default;
    [SerializeField] GameObject AddObj = default;
    [SerializeField] ShopManager shopManager = default;
    /// <summary>値のロード </summary>
    void Start()
    {
        Debug.Log("ロード");
        gameManager.score = PlayerPrefs.GetInt("SCORE", 0);
        autoAdd.number = PlayerPrefs.GetInt("NUMBER", 0);
        shopManager.levelCount = PlayerPrefs.GetInt("COUNT", 0);
        shopManager.levelCount1 = PlayerPrefs.GetInt("COUNT1", 0);
        shopManager.levelCount2 = PlayerPrefs.GetInt("COUNT2", 0);
        shopManager.levelCount3 = PlayerPrefs.GetInt("COUNT3", 0);
        gameManager.delete = PlayerPrefs.GetFloat("DELETE",1.0f);
        shopManager.cane = PlayerPrefs.GetFloat("SHOP", 10);
        shopManager.wheelchair = PlayerPrefs.GetFloat("SHOP1", 100);
        shopManager.supplement = PlayerPrefs.GetFloat("SHOP2", 1000);
        shopManager.money = PlayerPrefs.GetFloat("SHOP3",5000);
        shopManager.inc = PlayerPrefs.GetFloat("INC", 0);
        shopManager.inc1 = PlayerPrefs.GetFloat("INC1", 0);
        shopManager.inc2 = PlayerPrefs.GetFloat("INC2", 0);
        shopManager.inc3 = PlayerPrefs.GetFloat("INC3", 0);
        shopManager.inc4 = PlayerPrefs.GetFloat("INC4", 0);
        if (autoAdd.number > 0)
        {
            AddObj.SetActive(true);
        }
    }
    /// <summary>値の保存</summary>
    void OnDestroy()
    {
        PlayerPrefs.SetInt("SCORE", gameManager.score);
        PlayerPrefs.SetInt("NUMBER", autoAdd.number);
        PlayerPrefs.SetInt("COUNT", shopManager.levelCount);
        PlayerPrefs.SetInt("COUNT1", shopManager.levelCount1);
        PlayerPrefs.SetInt("COUNT2", shopManager.levelCount2);
        PlayerPrefs.SetInt("COUNT3", shopManager.levelCount3);
        PlayerPrefs.SetFloat("DELETE", gameManager.delete);
        PlayerPrefs.SetFloat("SHOP", shopManager.cane);
        PlayerPrefs.SetFloat("SHOP1", shopManager.wheelchair);
        PlayerPrefs.SetFloat("SHOP2", shopManager.supplement);
        PlayerPrefs.SetFloat("SHOP3", shopManager.money);
        PlayerPrefs.SetFloat("INC", shopManager.inc);
        PlayerPrefs.SetFloat("INC1", shopManager.inc1);
        PlayerPrefs.SetFloat("INC2", shopManager.inc2);
        PlayerPrefs.SetFloat("INC3", shopManager.inc3);
        PlayerPrefs.SetFloat("INC4", shopManager.inc4);
        PlayerPrefs.Save();
        Debug.Log("セーブ");
    }
    void Update()
    {
        
    }
    /// <summary>全値のリセット</summary>
    public void OnReset()
    {
        Debug.Log("リセット");
        gameManager.score = 0;
        autoAdd.number = 0;
        gameManager.delete = 1.0f;
        shopManager.cane = 10;
        shopManager.wheelchair = 100;
        shopManager.supplement = 1000;
        shopManager.money = 5000;
        shopManager.levelCount = 0;
        shopManager.levelCount1 = 0;
        shopManager.levelCount2 = 0;
        shopManager.levelCount3 = 0;
        shopManager.inc = 0;
        shopManager.inc1 = 0;
        shopManager.inc2 = 0;
        shopManager.inc3 = 0;
        shopManager.inc4 = 0;
    }
}