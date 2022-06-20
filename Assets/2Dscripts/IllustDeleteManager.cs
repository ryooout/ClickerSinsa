using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IllustDeleteManager : MonoBehaviour
{ 
    [SerializeField]ShopManager shopManager = default;
    [SerializeField]AudioManager audioManager = default;
    [SerializeField]GameManager gameManager = default;
    float rand;
    void Start()
    {      
        shopManager = GameObject.Find("ShopManager").GetComponent<ShopManager>();
        audioManager = GameObject.Find("AudioObj").GetComponent<AudioManager>();
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        rand = Random.Range(1.5f, 4.5f);
    }
    public void ItemClick()
    {
        if (gameObject.tag == "Tue")
        {
            shopManager.auto *= 1.25f;
            audioManager.SE();
            Debug.Log("ñ‘‚¦‚½");
        }
        else if (gameObject.tag == "Kurumaisu")
        {
            shopManager.auto1 *= 1.25f;
            audioManager.SE();
            Debug.Log("Ô‚¢‚·‘‚¦‚½");
        }
        else if (gameObject.tag == "Sapuri")
        {
            shopManager.auto2 *= 1.25f;
            audioManager.SE();
            Debug.Log("ƒTƒvƒŠ‘‚¦‚½");
        }
        else if (gameObject.tag == "Otoshidama")
        {
            shopManager.auto3 *= 1.25f;
            audioManager.SE();
            Debug.Log("‚¨”N‹Ê‘‚¦‚½");
        }
        else if(gameObject.tag =="GoldHeart")
        {
            gameManager.AddScore(Mathf.FloorToInt(gameManager.score*rand));
            audioManager.SE2();
        }
    }
}
