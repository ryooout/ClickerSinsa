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
        if (Input.GetMouseButtonUp(0) && gameObject.tag == "Ojisan")
        {
            Instantiate(gameManager.particle, transform.position, transform.rotation);
            gameManager.AddScore(2);
            Debug.Log(gameManager.score);
            gameObject.GetComponent<Renderer>().enabled = false;
        }
        else if (Input.GetMouseButtonUp(0) && gameObject.tag == "Ojisan1")
        {
            Instantiate(gameManager.particle, transform.position, transform.rotation);
            gameManager.AddScore(5);
            Debug.Log(gameManager.score);
            gameObject.GetComponent<Renderer>().enabled = false;
        }
        else if (Input.GetMouseButtonUp(0) && gameObject.tag == "Ojisan2")
        {
            Instantiate(gameManager.particle, transform.position, transform.rotation);
            gameManager.AddScore(9);
            Debug.Log(gameManager.score);
            gameObject.GetComponent<Renderer>().enabled = false;
        }
        else if (Input.GetMouseButtonUp(0) && gameObject.tag == "Ojisan3")
        {
            Instantiate(gameManager.particle, transform.position, transform.rotation);
            gameManager.AddScore(11);
            Debug.Log(gameManager.score);
            gameObject.GetComponent<Renderer>().enabled = false;
        }
    }
}
