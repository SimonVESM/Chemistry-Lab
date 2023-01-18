using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptimizedSpill : MonoBehaviour
{
    ParticleSystem spillLiquid;
    ParticleSystem.EmissionModule em;
    void Start()
    {
        spillLiquid = GetComponent<ParticleSystem>();
        em = spillLiquid.emission;
    }
    void Update()
    {
        em.enabled = Vector3.Angle(Vector3.down, transform.forward) <= 90f;
    }
}