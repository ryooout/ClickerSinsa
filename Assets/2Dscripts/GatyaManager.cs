using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GatyaManager : MonoBehaviour
{
    [SerializeField]GameManager gameManager = default;
    [SerializeField]ShopManager shopManager = default;
    [SerializeField] AutoAdd autoAdd = default;
    [SerializeField] GameObject autoObj = default;
    [SerializeField] GameObject backGroundObj = default;
    [SerializeField]GameObject  gatyaPrefab = default;
    /// <summary>���ʎ���</summary>
    public Text gatyaTimer = default;
    [SerializeField] Text notRotate = default;
    /// <summary>�K�`���̒l�i�\�� </summary>
    [SerializeField] Text gatyaPriceText = default;
    /// <summary>���ʉ� </summary>
    AudioSource gatyaAudioSource = null;
    /// <summary>�K�`�����̉�</summary>
    public AudioClip[]gatyaSound = default;
    /// <summary>�n�[�g�^�̃I�u�W�F�N�g </summary>
    [SerializeField] GameObject heart = default;
    /// <summary>�K�`������o�����</summary>
    [SerializeField] GameObject[] katuraPrefab = default;
    [SerializeField] RawImage hazureText = default;
    /// <summary>�K�`������̃{�^��</summary>
    [SerializeField] Button[] gatyaButton = default;
    /// <summary>�K�`������</summary>
    [SerializeField] Text[] gatyaResultText = default;
    /// <summary>�����̃n�[�g</summary>
    [SerializeField]GameObject goldHeart = default;
    /// <summary>���x���A�b�v�ʒm</summary>
    [SerializeField] RawImage levelUpText = default;
    /// <summary>�K�`�����J�� </summary>
    /// 
    int i;
    /// <summary>1�b������̒l�̑�����</summary>
    int i0 = 20;
    int i1 = 40;
    int i2 = 60;
    int i3 = 80;
    int random;
    float gatyaIncrese = 1;
    float gatyaIncrese1 = 1;
    float gatyaIncrese2 = 1;
    float gatyaIncrese3 = 1;
    float _double = 1.05f;
    public int gatyaPrice = 1000;
    GameObject katura = default;
    GameObject timerObj = default;
    float x;
    float y;
    float x1;
    float y1;
    private void Awake()
    {
        gatyaAudioSource = GetComponent<AudioSource>();
    }
    void Start()
    {
        timerObj = GameObject.Find("GatyaTimer");
        notRotate.gameObject.SetActive(false);
        gatyaButton[0].gameObject.SetActive(true);
        gatyaButton[1].gameObject.SetActive(false);
        gatyaTimer.gameObject.SetActive(false);
        gatyaPrefab.SetActive(false); 
    }

    // Update is called once per frame
    void Update()
    {
        x = Random.Range(-10, 10);
        y = Random.Range(-4,4);
        x1 = Random.Range(-10, 10);
        y1 = Random.Range(-4, 4);
        random = Random.Range(1, 6);
        i = Random.Range(0, katuraPrefab.Length+2);
        gatyaPriceText.text = "       " + "�K�`��\n�e���x:" + gatyaPrice + "��";
    }
   public void GatyaBuyClick()
    {
        if(i==0&&timerObj.activeSelf)
        {
            gatyaResultText[0].gameObject.SetActive(true);
        }
        else if (i == 1 && timerObj.activeSelf)
        {
            gatyaResultText[1].gameObject.SetActive(true);
        }
        else if (i == 2 && timerObj.activeSelf)
        {
            gatyaResultText[2].gameObject.SetActive(true);
        }
        else if (i == 3 && timerObj.activeSelf)
        {
            gatyaResultText[3].gameObject.SetActive(true);
        }
    }
    public void GatyaClick()
    { 
        if (gameManager.score >= 1000&&!timerObj.activeSelf)
        {
            gatyaTimer.gameObject.SetActive(true);
            notRotate.gameObject.SetActive(false);
           /* heart.SetActive(true);
            backGroundObj.SetActive(true);
            gatyaAudioSource.PlayOneShot(gatyaSound[0]);
            gatyaPrefab.GetComponent<Renderer>().material.color = Color.magenta;*/
           katura = Instantiate(katuraPrefab[i], new Vector2(0, 3), Quaternion.identity);
            gameManager.score -= gatyaPrice;
            gatyaPrice += Mathf.FloorToInt(100*_double);
            _double += 0.01f;
            if (timerObj.activeSelf)
            {
                if (i==0)//black
                {
                    heart.SetActive(true);
                    backGroundObj.SetActive(true);
                    gatyaAudioSource.PlayOneShot(gatyaSound[0]);
                    gatyaPrefab.GetComponent<Renderer>().material.color = Color.magenta;
                    gameManager.delete += 3.0f;
                    autoObj.SetActive(true);
                    levelUpText.gameObject.SetActive(true);
                    Invoke(nameof(LevelUp), 2.0f);
                    autoAdd.gatyaNumber += Mathf.FloorToInt(i0*gatyaIncrese);
                    gatyaIncrese *= 1.25f;
                    Debug.Log("black");
                    gameManager.span = 0.7f;
                    gatyaResultText[0].gameObject.SetActive(true);
                    autoAdd.number += Mathf.FloorToInt((1 * shopManager.auto) + 1);
                    shopManager.levelCount++;
                    shopManager.inc += 0.50f;
                    shopManager.inc1 += 0.65f;
                    shopManager.inc2 += 0.75f;
                    shopManager.inc3 += 0.85f;
                    shopManager.inc4 += 0.95f;
                    if(shopManager.levelCount%5 ==0)
                    {
                        Instantiate(shopManager.itemPrefab[0],new Vector2(x,y),Quaternion.identity);
                    }
                }
                else if (i == 1)//gold
                {
                    heart.SetActive(true);
                    backGroundObj.SetActive(true);
                    gatyaAudioSource.PlayOneShot(gatyaSound[0]);
                    gatyaPrefab.GetComponent<Renderer>().material.color = Color.magenta;
                    gameManager.delete += 3.0f;
                    autoObj.SetActive(true);
                    levelUpText.gameObject.SetActive(true);
                    Invoke(nameof(LevelUp), 2.0f);
                    autoAdd.gatyaNumber += Mathf.FloorToInt(i1*gatyaIncrese1);
                    gatyaIncrese1 *= 1.25f;
                    Debug.Log("gold");
                    gameManager.span = 0.8f;
                    gatyaResultText[1].gameObject.SetActive(true);
                    autoAdd.number += Mathf.FloorToInt((3 * shopManager.auto1) + 2);
                    shopManager.levelCount1++;
                    shopManager.inc += 0.65f;
                    shopManager.inc1 += 0.75f;
                    shopManager.inc2 += 0.85f;
                    shopManager.inc3 += 0.90f;
                    shopManager.inc4 += 1.0f;
                    if (shopManager.levelCount1 % 5 == 0)
                    {
                        Instantiate(shopManager.itemPrefab[1], new Vector2(x, y), Quaternion.identity);
                    }
                }
                else if (i == 2)//short
                {
                    heart.SetActive(true);
                    backGroundObj.SetActive(true);
                    gatyaAudioSource.PlayOneShot(gatyaSound[0]);
                    gatyaPrefab.GetComponent<Renderer>().material.color = Color.magenta;
                    gameManager.delete += 3.0f;
                    autoObj.SetActive(true);
                    levelUpText.gameObject.SetActive(true);
                    Invoke(nameof(LevelUp), 2.0f);
                    autoAdd.gatyaNumber += Mathf.FloorToInt(i2*gatyaIncrese2);
                    gatyaIncrese2 *= 1.25f;
                    Debug.Log("short");
                    gameManager.span = 0.9f;
                    gatyaResultText[2].gameObject.SetActive(true);
                    autoAdd.number += Mathf.FloorToInt((5 * shopManager.auto2) + 3);
                    gameManager.delete += 0.3f;
                    shopManager.levelCount2++;
                    shopManager.inc += 0.75f;
                    shopManager.inc1 += 0.85f;
                    shopManager.inc2 += 0.95f;
                    shopManager.inc3 += 1.0f;
                    shopManager.inc4 += 1.15f;
                    if (shopManager.levelCount2 % 5 == 0)
                    {
                        Instantiate(shopManager.itemPrefab[2], new Vector2(x, y), Quaternion.identity);
                    }
                }               
                else if(i == 3)//short2
                {
                    heart.SetActive(true);
                    backGroundObj.SetActive(true);
                    gatyaAudioSource.PlayOneShot(gatyaSound[0]);
                    gatyaPrefab.GetComponent<Renderer>().material.color = Color.magenta;
                    gameManager.delete += 3.0f;
                    autoObj.SetActive(true);
                    levelUpText.gameObject.SetActive(true);
                    Invoke(nameof(LevelUp), 2.0f);
                    autoAdd.gatyaNumber += Mathf.FloorToInt(i3*gatyaIncrese3);
                    gatyaIncrese3 *= 1.25f;
                    Debug.Log("short2");
                    gameManager.span = 1.0f;
                    gatyaResultText[3].gameObject.SetActive(true);
                    autoAdd.number += Mathf.FloorToInt((15 * shopManager.auto3) + 4);
                    gameManager.delete += 0.7f;
                    gameManager.AddScore(350);
                    shopManager.levelCount3++;
                    shopManager.inc += 0.85f;
                    shopManager.inc1 += 0.95f;
                    shopManager.inc2 += 1.0f;
                    shopManager.inc3 += 1.15f;
                    shopManager.inc4 += 1.25f;
                    if (shopManager.levelCount3 % 5 == 0)
                    {
                        Instantiate(shopManager.itemPrefab[3], new Vector2(x, y), Quaternion.identity);
                    }
                }
                else if(i==4||i==5)
                {
                    gatyaTimer.gameObject.SetActive(false);
                    hazureText.gameObject.SetActive(true);
                    Invoke(nameof(LevelUp), 2.0f);
                    gatyaAudioSource.PlayOneShot(gatyaSound[2]);
                }
                Invoke(nameof(Generater), 10.0f);
                if(random==3&&!(i ==4||i==5))
                {
                   var obj = Instantiate(goldHeart,new Vector2(x1,y1),Quaternion.identity);
                    Destroy(obj, 10.0f);
                }      
            }
        }        
        else if(gameManager.score < 1000||timerObj.activeSelf)
        {
            notRotate.gameObject.SetActive(true);
            gatyaPrefab.GetComponent<Renderer>().material.color = Color.red;
            Invoke(nameof(NotRotate), 2.0f);
            gameManager.span = 1.5f;
        }
       
    }
   public void Generater()
    {
        gameManager.delete -= 1.0f;
        gatyaAudioSource.PlayOneShot(gatyaSound[1]);
        katura.SetActive(false);
        gatyaTimer.gameObject.SetActive(false);
        heart.SetActive(false);
        gatyaPrefab.GetComponent<Renderer>().material.color = Color.white;
        gatyaResultText[0].gameObject.SetActive(false);
        gatyaResultText[1].gameObject.SetActive(false);
        gatyaResultText[2].gameObject.SetActive(false);
        gatyaResultText[3].gameObject.SetActive(false);
        backGroundObj.SetActive(false);
        if (i == 0)
        {
            autoAdd.gatyaNumber = 0;
            gameManager.span = 1.5f;
        }
        else if (i == 1)
        {
            autoAdd.gatyaNumber = 0;
            gameManager.span = 1.5f;          
        }
        else if (i == 2)
        {
            autoAdd.gatyaNumber = 0;
            gameManager.span = 1.5f;          
        }
        else if (i == 3)
        {
            autoAdd.gatyaNumber = 0;
            gameManager.span = 1.5f;         
        }
    }
    void NotRotate()
    {
        notRotate.gameObject.SetActive(false);
        gatyaPrefab.GetComponent<Renderer>().material.color = Color.white;
    }
    void LevelUp()
    {
        hazureText.gameObject.SetActive(false);
        levelUpText.gameObject.SetActive(false);
    }
}
