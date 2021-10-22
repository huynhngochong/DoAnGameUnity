using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollector : MonoBehaviour
{
    int vaccines = 0;

    [SerializeField] Text vaccinesText;

    [SerializeField] AudioSource collectionSound;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Vaccines"))
        {
            Destroy(other.gameObject);
            vaccines++;
            vaccinesText.text = "Vaccines: " + vaccines;
            collectionSound.Play();
        }
    }

}

