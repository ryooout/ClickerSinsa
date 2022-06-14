using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke(nameof(DestroyParticle),0.5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void DestroyParticle()
    {
        Destroy(gameObject);
    }
}
