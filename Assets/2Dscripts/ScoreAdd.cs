using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreAdd : MonoBehaviour
{
    [SerializeField] GameManager gameManager = default;
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }
    void Update()
    {
    }
    public void OnClick()
    {
        if (Input.GetMouseButtonUp(0)&&gameObject.tag == "Ojisan")
        {
            Instantiate(gameManager.particle, transform.position, transform.rotation);
            gameManager.AddScore(5);
            Debug.Log(gameManager.score);
        }
        else if (Input.GetMouseButtonUp(0) && gameObject.tag == "Ojisan1")
        {
            Instantiate(gameManager.particle, transform.position, transform.rotation);
            gameManager.AddScore(10);
            Debug.Log(gameManager.score);
        }
        else if (Input.GetMouseButtonUp(0) && gameObject.tag == "Ojisan2")
        {
            Instantiate(gameManager.particle, transform.position, transform.rotation);
            gameManager.AddScore(15);
            Debug.Log(gameManager.score);
        }
        else if (Input.GetMouseButtonUp(0) && gameObject.tag == "Ojisan3")
        {
            Instantiate(gameManager.particle, transform.position, transform.rotation);
            gameManager.AddScore(20);
            Debug.Log(gameManager.score);
        }
        else if(Input.GetMouseButtonUp(0) && gameObject.tag =="DefaultOjisan")
        {
            gameManager.AddScore(1);
        }
    }
}
