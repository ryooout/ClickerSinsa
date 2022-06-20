using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreAdd : MonoBehaviour
{
    [SerializeField] GameManager gameManager = default;
    [SerializeField] AudioManager audioManager = default;
    int add = 5;
    int add1 = 10;
    int add2 = 15;
    int add3 = 20;
    int add4 = 1;
   public float increse = 1;
   public float increse1 = 1;
   public float increse2 = 1;
   public float increse3 = 1;
   public float increse4 = 1;
    void Start()
    {
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
            gameManager.AddScore(Mathf.FloorToInt(add*increse));
            Debug.Log(gameManager.score);
            audioManager.SE();
        }
        else if (gameObject.tag == "Ojisan1")
        {
            Instantiate(gameManager.particle, transform.position, transform.rotation);
            gameManager.AddScore(Mathf.FloorToInt(add1*increse1));
            Debug.Log(gameManager.score);
            audioManager.SE();
        }
        else if (gameObject.tag == "Ojisan2")
        {
            Instantiate(gameManager.particle, transform.position, transform.rotation);
            gameManager.AddScore(Mathf.FloorToInt(add2*increse2));
            Debug.Log(gameManager.score);
            audioManager.SE();
        }
        else if (gameObject.tag == "Ojisan3")
        {
            Instantiate(gameManager.particle, transform.position, transform.rotation);
            gameManager.AddScore(Mathf.FloorToInt(add3*increse3));
            Debug.Log(gameManager.score);
            audioManager.SE();
        }
        else if(gameObject.tag =="DefaultOjisan")
        {
            gameManager.AddScore(Mathf.FloorToInt(add4*increse4));
            Debug.Log(gameManager.score);
            audioManager.SE();
        }
    }
}
