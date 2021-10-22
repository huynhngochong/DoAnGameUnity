using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollectVaccines : MonoBehaviour
{
    public AudioSource collectSound;

    void OnTriggerEnter(Collider other)
    {  
            collectSound.Play();
            ScoringSystem.theScore += 1;
            Destroy(gameObject);
    }

}
