using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spill : MonoBehaviour
{
    ParticleSystem spillLiquid;
    ParticleSystem.EmissionModule em;
    

    // Start is called before the first frame update
    void Start()
    {
        spillLiquid = GetComponent<ParticleSystem>();
        spillLiquid.Clear();
        em = spillLiquid.emission;
    }

    // Update is called once per frame
    void Update()
    {
        if(Vector3.Angle(Vector3.down, transform.forward) <= 90f)
   
        {
            if(!spillLiquid.isPlaying)
            {
                spillLiquid.Play();
            } 
        }

        else
        {
            spillLiquid.Stop();
        }
       
    }
}
