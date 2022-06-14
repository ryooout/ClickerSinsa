using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class EnemyManager : MonoBehaviour
{
    /// <summary>“G‚ÌŠi”[</summary>
    [SerializeField]GameObject gameObjects = default;
    [SerializeField] TextMeshProUGUI enemyHpText;
    public uint enemyHp = 10;
    void Start()
    {
        Instantiate(gameObjects,transform.position,transform.rotation);
        enemyHpText.text = "HP:"+enemyHp.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        EnemyHp();
    }
    private void EnemyHp()
    {
        if (Input.anyKeyDown)
        {
            enemyHp--;
        }
        else if (Input.anyKeyDown&&enemyHp == 0)
        {
           gameObjects.SetActive(false);
        }
        enemyHpText.text = "HP:" + enemyHp.ToString();
    }
}
