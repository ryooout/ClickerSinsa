
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using UnityEngine;

public class SaveManager : MonoBehaviour
{
    [SerializeField] GameManager gameManager = default;
    [SerializeField] AutoAdd autoAdd = default;
    [SerializeField] GameObject AddObj = default;
    [SerializeField] ShopManager shopManager = default;
    [SerializeField] GatyaManager gatyaManager = default;
    /// <summary>値のロード </summary>
    void Start()
    {
        Debug.Log("ロード");
        gameManager.score = PlayerPrefs.GetInt("SCORE", gameManager.score);
        autoAdd.number = PlayerPrefs.GetInt("NUMBER", autoAdd.number);
        shopManager.levelCount = PlayerPrefs.GetInt("COUNT", shopManager.levelCount);
        shopManager.levelCount1 = PlayerPrefs.GetInt("COUNT1", shopManager.levelCount1);
        shopManager.levelCount2 = PlayerPrefs.GetInt("COUNT2", shopManager.levelCount2);
        shopManager.levelCount3 = PlayerPrefs.GetInt("COUNT3", shopManager.levelCount3);
        gameManager.delete = PlayerPrefs.GetFloat("DELETE",gameManager.delete);
        shopManager.cane = PlayerPrefs.GetFloat("SHOP", shopManager.cane);
        shopManager.wheelchair = PlayerPrefs.GetFloat("SHOP1", shopManager.wheelchair);
        shopManager.supplement = PlayerPrefs.GetFloat("SHOP2", shopManager.supplement);
        shopManager.money = PlayerPrefs.GetFloat("SHOP3",shopManager.money);
        shopManager.inc = PlayerPrefs.GetFloat("INC", shopManager.inc);
        shopManager.inc1 = PlayerPrefs.GetFloat("INC1", shopManager.inc1);
        shopManager.inc2 = PlayerPrefs.GetFloat("INC2", shopManager.inc2);
        shopManager.inc3 = PlayerPrefs.GetFloat("INC3", shopManager.inc3);
        shopManager.inc4 = PlayerPrefs.GetFloat("INC4", shopManager.inc4);
        gatyaManager.gatyaPrice = PlayerPrefs.GetInt("GATYA", gatyaManager.gatyaPrice);
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
        PlayerPrefs.SetInt("GATYA", gatyaManager.gatyaPrice);
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
        shopManager.supplement = 900;
        shopManager.money = 2000;
        shopManager.levelCount = 0;
        shopManager.levelCount1 = 0;
        shopManager.levelCount2 = 0;
        shopManager.levelCount3 = 0;
        shopManager.inc = 1;
        shopManager.inc1 = 1;
        shopManager.inc2 = 1;
        shopManager.inc3 = 1;
        shopManager.inc4 = 1;
        gatyaManager.gatyaPrice = 1000;
    }
}