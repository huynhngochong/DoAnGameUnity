using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerLife : MonoBehaviour
{
    public static bool Check;

    bool dead;

    [SerializeField] AudioSource deathSound;
    private void Update()
    {
        if (transform.position.y < -5f && !dead)
        {
            Die();
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy Body"))
        {
            GetComponent<MeshRenderer>().enabled = false;
            GetComponent<Rigidbody>().isKinematic = true;
            GetComponent<PlayerMoment>().enabled = false;
            Die();
        }
    }


   

    void Die()
    {
        Check = true;
        dead = true;
        Invoke(nameof(ReloadLevel),0.5f);
        deathSound.Play();
    }
    public void ReloadLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
