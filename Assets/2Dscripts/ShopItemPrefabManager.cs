using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopItemPrefabManager : MonoBehaviour
{
    [SerializeField]ShopManager shopManager = default;
    [SerializeField] GameObject[]itemPrefab = default;
    float x0 = -12;
    float x1 = -12;
    float x2 = -12;
    float x3 = -12;
    float y0 = -4;
    float y1 = 0;
    float y2 = -2;
    float y3 = -4;
    void Start()
    {
        shopManager.shopButton[0].onClick.AddListener(() =>
        {
            Instantiate(itemPrefab[0], new Vector2(x0, y0), Quaternion.identity);
            x0 += 0.2f;
        });
        shopManager.shopButton[1].onClick.AddListener(() =>
        {
            Instantiate(itemPrefab[1], new Vector2(x1, y1), Quaternion.identity);
            x1 += 0.2f;
        });
        shopManager.shopButton[2].onClick.AddListener(() =>
        {
            Instantiate(itemPrefab[2], new Vector2(x2, y2), Quaternion.identity);
            x2 += 0.2f;
        });
        shopManager.shopButton[3].onClick.AddListener(() =>
        {
            Instantiate(itemPrefab[2], new Vector2(x3, y3), Quaternion.identity);
            x3 += 0.2f;
        });
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
