using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class GameManager : MonoBehaviour
{
    private int i;
    public float span = 2.5f;
    private float time;
    public int score;
    public float delete = 1.0f;
    [SerializeField] ShopManager shop = default;
    [SerializeField]GameObject[]ojisan = default;
    [SerializeField] TextMeshProUGUI scoreText = default;
    public Text[] shopText;
    public GameObject particle;
    void Start()
    {
        scoreText.text = "�e���x:"+score.ToString();
        shopText[0].text = "��\n�e���x:" + shop.cane.ToString();
        shopText[1].text = "�Ԃ���\n�e���x:" + shop.wheelchair.ToString();
        shopText[2].text = "�T�v��\n�e���x:" + shop.supplement.ToString();
        shopText[3].text = "���N�ʂ𑗂�\n�e���x:" + shop.money.ToString();
    }
     
    // Update is called once per frame
    void Update()
    {
        Generation();
        ScoreText(score);
        StoreText();
    }
    private void Generation()
    {
        time += Time.deltaTime;
        i = Random.Range(0, ojisan.Length);
        float x = Random.Range(-11, 11);
        float y = Random.Range(-4, 4);
        if (time > span)
        {
            Instantiate(ojisan[i], new Vector2(x, y), Quaternion.identity);
            time = 0;
        }

    }
    private void ScoreText(int score)
    {
        scoreText.text = "�e���x:"+score.ToString();
    }
    public void AddScore(int addScore)
    {
        score += addScore;
        ScoreText(score);
    }
   private void StoreText()
    {
        shopText[0].text = "��\n�e���x:" + shop.cane.ToString()+"��";
        shopText[1].text = "�Ԃ���\n�e���x:" + shop.wheelchair.ToString()+ "��";
        shopText[2].text = "�T�v��\n�e���x:" + shop.supplement.ToString()+ "��";
        shopText[3].text = "���N�ʂ𑗂�\n�e���x:" + shop.money.ToString()+ "��";
    }
}
