using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleManager : MonoBehaviour
{ 
    void Start()
    {
        Invoke(nameof(DestroyParticle),0.5f);
    }
    void Update()
    {
        
    }
    void DestroyParticle()
    {
        Destroy(gameObject);
    }
}
