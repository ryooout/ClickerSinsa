using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreAdd : MonoBehaviour
{
    [SerializeField] GameManager gameManager = default;
    [SerializeField] AudioManager audioManager = default;
    [SerializeField] ShopManager shopManager = default;
    int add = 5;
    int add1 = 10;
    int add2 = 15;
    int add3 = 20;
    int add4 = 1;
    void Start()
    {
        shopManager = GameObject.Find("ShopManager").GetComponent<ShopManager>();
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        audioManager = GameObject.Find("AudioObj").GetComponent<AudioManager>();
    }
    void Update()
    {
    }
    public void OnClick()
    {
        if (gameObject.tag == "Ojisan")
        {
            Instantiate(gameManager.particle, transform.position, transform.rotation);
            gameManager.AddScore(Mathf.FloorToInt(add+shopManager.inc));
            Debug.Log(gameManager.score);
            audioManager.SE();
        }
        else if (gameObject.tag == "Ojisan1")
        {
            Instantiate(gameManager.particle, transform.position, transform.rotation);
            gameManager.AddScore(Mathf.FloorToInt(add1+shopManager.inc1));
            Debug.Log(gameManager.score);
            audioManager.SE();
        }
        else if (gameObject.tag == "Ojisan2")
        {
            Instantiate(gameManager.particle, transform.position, transform.rotation);
            gameManager.AddScore(Mathf.FloorToInt(add2+shopManager.inc2));
            Debug.Log(gameManager.score);
            audioManager.SE();
        }
        else if (gameObject.tag == "Ojisan3")
        {
            Instantiate(gameManager.particle, transform.position, transform.rotation);
            gameManager.AddScore(Mathf.FloorToInt(add3+shopManager.inc3));
            Debug.Log(gameManager.score);
            audioManager.SE();
        }
        else if(gameObject.tag =="DefaultOjisan")
        {
            gameManager.AddScore(Mathf.FloorToInt(add4*shopManager.inc4));
            Debug.Log(gameManager.score);
            audioManager.SE();
        }
    }
}
