using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ShopManager : MonoBehaviour
{
    [SerializeField] GameManager gameManager = default;
    [SerializeField] AutoAdd autoAdd = default;
    /// <summary>�A�C�e���{�^���ꗗ</summary>
    public Button[] shopButton = default;
    /// <summary>shop��open,close</summary>
    [SerializeField] GameObject[]shopOpen = default;
    [SerializeField] GameObject AddObj = default;
    /// <summary>��</summary>
    public int cane = 10;
    /// <summary>�Ԃ���</summary>
    public int wheelchair = 100;
    /// <summary>�T�v��</summary>
    public int supplement = 1000;
    /// <summary>����</summary>
    public int money = 5000;
    public GameObject[] itemPrefab = default;
    float x0 = -11;
    float x1 = -11;
    float x2 = -11;
    float x3 = -11;
    float y0 = 2;
    float y1 = 0;
    float y2 = -2;
    float y3 = -4;
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
            cane += 13;
            autoAdd.number++;
            Instantiate(itemPrefab[0],new Vector2(x0,y0),Quaternion.identity);
            if (x0 >= 12.0f)
            { x0 = -11; }
            x0 += 0.15f;
        });
        shopButton[1].onClick.AddListener(() =>
        {�@�@�@�@�@�@�@�@�@�@�@�@�@�@�@�@�@�@�@
            if (gameManager.score < wheelchair) return;
            AddObj.SetActive(true);
            gameManager.score -= wheelchair;
            wheelchair += 53;
            autoAdd.number += 3;
            Instantiate(itemPrefab[1], new Vector2(x1, y1), Quaternion.identity);
            if (x1 >= 12.0f)
            { x1 = -11; }
            x1 += 0.3f;
        });
        shopButton[2].onClick.AddListener(() =>
        {                                        
            if (gameManager.score < supplement) return;
            AddObj.SetActive(true);
            gameManager.score -= supplement;
            supplement += 563;
            autoAdd.number += 5;
            gameManager.delete += 0.2f;
            Instantiate(itemPrefab[2], new Vector2(x2, y2), Quaternion.identity);
            if (x2 >= 12.0f)
            { x2 = -11; }
            x2 += 0.3f;
        });
        shopButton[3].onClick.AddListener(() =>
        {
            if (gameManager.score < money) return;
            AddObj.SetActive(true);
            gameManager.score -= money;
            money += 2103;
            autoAdd.number += 15;
            gameManager.delete += 0.35f;
            Instantiate(itemPrefab[3], new Vector2(x3, y3), Quaternion.identity);
            gameManager.AddScore(350);
            if(x3 >= 12.0f)
            { x3 = -11; }
            x3 += 0.3f;
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
