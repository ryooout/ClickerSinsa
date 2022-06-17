
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class SaveManager : MonoBehaviour
{
    [SerializeField]GameManager gameManager = default;
    [SerializeField] AutoAdd autoAdd = default;
    [SerializeField] GameObject AddObj = default;
    void Start()
    {
        gameManager.score = PlayerPrefs.GetInt("SCORE", 0);
        autoAdd.number = PlayerPrefs.GetInt("NUMBER", 0);
        if(autoAdd.number > 0)
        {
            AddObj.SetActive(true);
        }
    }
    /// <summary>値の保存</summary>
    void OnDestroy()
    {
        PlayerPrefs.SetInt("SCORE", gameManager.score);
        PlayerPrefs.SetInt("NUMBER", autoAdd.number);
    }
    void Update()
    {
        
    }
    /// <summary>全値のリセット</summary>
    public void OnReset()
    {
        gameManager.score = 0;
        autoAdd.number = 0;
    }
}
