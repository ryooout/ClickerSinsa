
using System.Collections;
using System.Collections.Generic;
using System.Linq;
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
        gameManager.score = PlayerPrefs.GetInt("SCORE", 0);
        autoAdd.number = PlayerPrefs.GetInt("NUMBER", 0);
        gameManager.delete = PlayerPrefs.GetFloat("DELETE",1.0f);
        shopManager.cane = PlayerPrefs.GetInt("SHOP", 10);
        shopManager.wheelchair = PlayerPrefs.GetInt("SHOP1", 100);
        shopManager.supplement = PlayerPrefs.GetInt("SHOP2", 1000);
        shopManager.money = PlayerPrefs.GetInt("SHOP3",5000);
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
        PlayerPrefs.SetInt("SHOP", shopManager.cane);
        PlayerPrefs.SetInt("SHOP1", shopManager.wheelchair);
        PlayerPrefs.SetInt("SHOP2", shopManager.supplement);
        PlayerPrefs.SetInt("SHOP3", shopManager.money);
    }
    void Update()
    {
        
    }
    /// <summary>全値のリセット</summary>
    public void OnReset()
    {
        gameManager.score = 0;
        autoAdd.number = 0;
        gameManager.delete = 1.0f;
        shopManager.cane = 10;
        shopManager.wheelchair = 100;
        shopManager.supplement = 1000;
        shopManager.money = 5000;
    }
}