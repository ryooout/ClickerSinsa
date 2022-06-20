using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IllustDeleteManager : MonoBehaviour
{ 
    [SerializeField]ShopManager shopManager = default;
    [SerializeField]AudioManager audioManager = default;
    void Start()
    {      
        shopManager = GameObject.Find("ShopManager").GetComponent<ShopManager>();
        audioManager = GameObject.Find("AudioObj").GetComponent<AudioManager>();
    }

    // Update is called once per frame
    void Update()
    {
    }
    public void ItemClick()
    {
        if (gameObject.tag == "Tue")
        {
            shopManager.auto += 0.07f;
            audioManager.SE();
            Debug.Log("杖増えた");
        }
        else if (gameObject.tag == "Kurumaisu")
        {
            shopManager.auto1 += 0.11f;
            audioManager.SE();
            Debug.Log("車いす増えた");
        }
        else if (gameObject.tag == "Sapuri")
        {
            shopManager.auto2 += 0.13f;
            audioManager.SE();
            Debug.Log("サプリ増えた");
        }
        else if (gameObject.tag == "Otoshidama")
        {
            shopManager.auto3 += 0.15f;
            audioManager.SE();
            Debug.Log("お年玉増えた");
        }
    }
}
