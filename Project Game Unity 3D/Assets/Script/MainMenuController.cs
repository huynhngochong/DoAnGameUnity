using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MainMenuController : MonoBehaviour
{
    public void PlayGame()
    {

        int selectedCharater = int.Parse(UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject.name);

        GameManager.instance.CharIndex = selectedCharater;

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
