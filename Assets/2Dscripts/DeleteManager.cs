using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteManager : MonoBehaviour
{
    [SerializeField]GameManager gameManager = default;
    private void Awake()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }
    void Start()
    {
        Destroy(gameObject, gameManager.delete);
    }

    // Update is called once per frame
    void Update()
    {
    }

}
