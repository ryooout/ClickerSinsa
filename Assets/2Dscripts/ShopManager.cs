using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ShopManager : MonoBehaviour
{
    [SerializeField] GameManager gameManager = default;
    [SerializeField] AutoAdd autoAdd = default;
    /// <summary>�A�C�e���{�^���ꗗ</summary>
    [SerializeField] Button[] shopButton = default;
    /// <summary>shop��open,close</summary>
    [SerializeField] GameObject[]shopOpen = default;
    [SerializeField] GameObject AddObj = default;
    /// <summary>��</summary>
    public int cane = 50;
    /// <summary>�Ԃ���</summary>
    public int wheelchair = 150;
    /// <summary>�T�v��</summary>
    public int supplement = 300;
    /// <summary>����</summary>
    public int money = 500;
    private void Awake()
    {
       AddObj.SetActive(false);
        shopOpen[0].SetActive(true);//�V���b�v�I�[�v��
        shopOpen[1].SetActive(false);//�V���b�v�N���[�Y
        shopOpen[2].SetActive(false);//�V���b�v�A�C�e���ꗗ
    }
    void Start()
    {
        //�EAddListener...�X�N���v�g����{�^���̃C�x���g���Ăяo�����Ƃ��o����
        shopButton[0].onClick.AddListener(() =>
        {�@�@�@�@�@�@�@�@�@�@�@�@�@�@�@�@�@//�l��Ԃ�
            if (gameManager.score < cane) return;
            AddObj.SetActive(true);
            gameManager.score -= cane;
            cane += 5;
            autoAdd.number++;
            
        });
        shopButton[1].onClick.AddListener(() =>
        {�@�@�@�@�@�@�@�@�@�@�@�@�@�@�@�@�@�@�@
            if (gameManager.score < wheelchair) return;
            AddObj.SetActive(true);
            gameManager.score -= wheelchair;
            wheelchair += 15;
            autoAdd.number += 3;
        });
        shopButton[2].onClick.AddListener(() =>
        {                                        
            if (gameManager.score < supplement) return;
            AddObj.SetActive(true);
            gameManager.score -= supplement;
            supplement += 30;
            autoAdd.number += 5;
            gameManager.delete += 0.2f;
        });
        shopButton[3].onClick.AddListener(() =>
        {
            if (gameManager.score < money) return;
            AddObj.SetActive(true);
            gameManager.score -= money;
            money += 50;
            autoAdd.number += 15;
            gameManager.AddScore(200);
            gameManager.delete += 0.5f;
        });
    }
    void Update()
    {
        ItemShopColor();
    }
    /// <summary>�l�ɂ���ĐF���ς��</summary>
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
