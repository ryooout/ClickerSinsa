using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ShopManager : MonoBehaviour
{
    [SerializeField] GameManager gameManager = default;
    [SerializeField,Header("�A�C�e���̃{�^��")]public Button[] shopButton = default;
    [SerializeField,Header("shop��open,close")] GameObject[] shopOpen = default;
    [SerializeField,Header("�������Z")] AutoAdd autoAdd = default;
    [SerializeField] GameObject AddObj = default;
    [SerializeField,Header("�A�C�e���w����")] Text[] itemBuyCount = default;
    [SerializeField,Header("��")]public float cane = 10;
    [SerializeField, Header("�Ԃ���")] public float wheelchair = 100;
    [SerializeField, Header("�T�v��")] public float supplement = 900;
    [SerializeField, Header("���N��")] public float money = 2000;
    [SerializeField,Header("�A�C�e��")]public GameObject[] itemPrefab = default;
    [SerializeField,Header("���x���A�b�v�̃J�E���g")]
    public int levelCount = 0;
    public int levelCount1 = 0;
    public int levelCount2 = 0;
    public int levelCount3 = 0;
    [SerializeField,Header("�l�i�̏㏸")]
    public float increse =  1;
    public float increse1 = 1;
    public float increse2 = 1;
    public float increse3 = 1;
    [SerializeField,Header("�l�̎������Z")]
    public float auto = 1;
    public float auto1 = 1;
    public float auto2 = 1;
    public float auto3 = 1;
    float x,y;
    [SerializeField,Header("����������N���b�N�����Ƃ��̒l�㏸")]
    public float inc = 1;
    public float inc1 = 1;
    public float inc2 = 1;
    public float inc3 = 1;
    public float inc4 = 1;
    private void Awake()
    {
       AddObj.SetActive(false);
        shopOpen[0].SetActive(true);//�V���b�v�I�[�v��
        shopOpen[1].SetActive(false);//�V���b�v�N���[�Y
        shopOpen[2].SetActive(false);//�V���b�v�A�C�e���ꗗ
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
    public void Generate()
    {
        //�EAddListener...�X�N���v�g����{�^���̃C�x���g���Ăяo�����Ƃ��o����
        shopButton[0].onClick.AddListener(() =>
        {�@�@�@�@�@�@�@�@�@�@�@�@�@�@�@�@�@//�l���Ⴉ������߂�l��Ԃ�
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
        itemBuyCount[0].text = "���x��:" + levelCount.ToString();
        itemBuyCount[1].text = "���x��:" + levelCount1.ToString();
        itemBuyCount[2].text = "���x��:" + levelCount2.ToString();
        itemBuyCount[3].text = "���x��:" + levelCount3.ToString();
    }   
}
