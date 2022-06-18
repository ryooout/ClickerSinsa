
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class SaveManager : MonoBehaviour
{
    [SerializeField]GameManager gameManager = default;
    [SerializeField] AutoAdd autoAdd = default;
    [SerializeField] GameObject AddObj = default;
    /// <summary>�l�̃��[�h </summary>
    void Start()
    {
        gameManager.score = PlayerPrefs.GetInt("SCORE", 0);
        autoAdd.number = PlayerPrefs.GetInt("NUMBER", 0);
        gameManager.delete = PlayerPrefs.GetFloat("DELETE",0);
        if(autoAdd.number > 0)
        {
            AddObj.SetActive(true);
        }
    }
    /// <summary>�l�̕ۑ�</summary>
    void OnDestroy()
    {
        PlayerPrefs.SetInt("SCORE", gameManager.score);
        PlayerPrefs.SetInt("NUMBER", autoAdd.number);
        PlayerPrefs.SetFloat("DELETE", gameManager.delete);
    }
    void Update()
    {
        
    }
    /// <summary>�S�l�̃��Z�b�g</summary>
    public void OnReset()
    {
        gameManager.score = 0;
        autoAdd.number = 0;
        gameManager.delete = 1.0f;
    }
}
