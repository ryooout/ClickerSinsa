
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
        gameManager.delete = PlayerPrefs.GetFloat("DELETE",1.0f);
        shopManager.cane = PlayerPrefs.GetFloat("SHOP", 10);
        shopManager.wheelchair = PlayerPrefs.GetFloat("SHOP1", 100);
        shopManager.supplement = PlayerPrefs.GetFloat("SHOP2", 1000);
        shopManager.money = PlayerPrefs.GetFloat("SHOP3",5000);
        shopManager.count = PlayerPrefs.GetInt("COUNT", 0);
        shopManager.count = PlayerPrefs.GetInt("COUNT1", 0);
        shopManager.count = PlayerPrefs.GetInt("COUNT2", 0);
        shopManager.count = PlayerPrefs.GetInt("COUNT3", 0);
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
        PlayerPrefs.SetFloat("DELETE", gameManager.delete);
        PlayerPrefs.SetFloat("SHOP", shopManager.cane);
        PlayerPrefs.SetFloat("SHOP1", shopManager.wheelchair);
        PlayerPrefs.SetFloat("SHOP2", shopManager.supplement);
        PlayerPrefs.SetFloat("SHOP3", shopManager.money);
        PlayerPrefs.SetInt("COUNT", shopManager.count);
        PlayerPrefs.SetInt("COUNT", shopManager.count1);
        PlayerPrefs.SetInt("COUNT", shopManager.count2);
        PlayerPrefs.SetInt("COUNT", shopManager.count3);
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
        shopManager.count = 0;
        shopManager.count1 = 0;
        shopManager.count2 = 0;
        shopManager.count3 = 0;
    }
}