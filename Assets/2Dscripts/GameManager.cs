using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class GameManager : MonoBehaviour
{
    private int i;
    [SerializeField,Header("��������o���Ԋu")]public float span = 1.5f;
    private float time;
    [SerializeField, Header("�e���x")] public int score;
    [SerializeField,Header("�������񂪏��ł���܂ł̎���")]public float delete = 1.2f;
    [SerializeField] ShopManager shop = default;
    [SerializeField,Header("��������B")]GameObject[]ojisan = default;
    [SerializeField,Header("�X�R�A")] TextMeshProUGUI scoreText = default;
    [SerializeField, Header("�V���b�v")] public Text[] shopText = default;
    [SerializeField,Header("�p�[�e�B�N��")]public GameObject particle = default;
    void Update()
    {
        Generation();
        ScoreText(score);
        StoreText();
    }
    /// <summary>�v���t�@�u�̐���</summary>
    private void Generation()
    {
        time += Time.deltaTime;
        i = Random.Range(0, ojisan.Length);
        float x = Random.Range(-10, 10);
        float y = Random.Range(-4, 4);
        if (time > span)
        {
            Instantiate(ojisan[i], new Vector2(x, y), Quaternion.identity);
            time = 0;
        }

    }
    private void ScoreText(int score)
    {
        scoreText.text = "�e���x:"+score.ToString()+"��";
    }
    public void AddScore(int addScore)
    {
        score +=addScore;
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
