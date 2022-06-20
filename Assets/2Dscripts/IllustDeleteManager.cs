using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IllustDeleteManager : MonoBehaviour
{ 
    [SerializeField]ShopManager shopManager = default;
    void Start()
    {      
        shopManager = GameObject.Find("ShopManager").GetComponent<ShopManager>();
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
            Debug.Log("ñ‘‚¦‚½");
        }
        else if (gameObject.tag == "Kurumaisu")
        {
            shopManager.auto1 += 0.11f;
            Debug.Log("Ô‚¢‚·‘‚¦‚½");
        }
        else if (gameObject.tag == "Sapuri")
        {
            shopManager.auto2 += 0.13f;
            Debug.Log("ƒTƒvƒŠ‘‚¦‚½");
        }
        else if (gameObject.tag == "Otoshidama")
        {
            shopManager.auto3 += 0.15f;
            Debug.Log("‚¨”N‹Ê‘‚¦‚½");
        }
    }
}
