using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class ScoringSystem : MonoBehaviour
{

    public GameObject scoreText;
    bool Check;
    public static int theScore = 0;

    private void Start()
    {
        Checker();

        scoreText.GetComponent<Text>().text = "Vaccines: " + theScore;

        //Checker();
    }
    void Checker()
    {
        if (PlayerLife.Check == true)
        {
            theScore = 0;
        }
    }
    public void Update()
    {
        scoreText.GetComponent<Text>().text = "Vaccines: " + theScore;

    }
   

   
}
