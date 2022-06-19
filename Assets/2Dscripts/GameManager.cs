using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class GameManager : MonoBehaviour
{
    private int i;
    public float span = 1.5f;
    private float time;
    public int score;
    public float delete = 1.0f;
    [SerializeField] ShopManager shop = default;
    [SerializeField]GameObject[]ojisan = default;
    [SerializeField] TextMeshProUGUI scoreText = default;
    public Text[] shopText = default;
    public GameObject particle = default;
    private void Awake()
    {
    }
    void Update()
    {
        Generation();
        ScoreText(score);
        StoreText();
    }
    /// <summary>プレファブの生成</summary>
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
        scoreText.text = "親密度:"+score.ToString()+"爺";
    }
    public void AddScore(int addScore)
    {
        score += addScore;
        ScoreText(score);
    }
   private void StoreText()
    {
        shopText[0].text = "杖\n親密度:" + shop.cane.ToString()+"爺";
        shopText[1].text = "車いす\n親密度:" + shop.wheelchair.ToString()+ "爺";
        shopText[2].text = "サプリ\n親密度:" + shop.supplement.ToString()+ "爺";
        shopText[3].text = "お年玉を送る\n親密度:" + shop.money.ToString()+ "爺";
    }
}
