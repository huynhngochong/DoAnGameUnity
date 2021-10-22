using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private GameObject[] Charaters;

    public static GameManager instance;

    private int _charIndex;

    public int CharIndex
    {
        get
        {
            return _charIndex;
        }
        set
        {
            _charIndex = value;
        }
    }
    public void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
    private void OnEnable()
    {
        SceneManager.sceneLoaded += OnLevelFinishLoading;
    }

    private void OnDisable()
    {
        SceneManager.sceneLoaded -= OnLevelFinishLoading;
    }

    void OnLevelFinishLoading(Scene scene, LoadSceneMode mode)
    {
        if (scene.name == "Level01")
        {
            Instantiate(Charaters[CharIndex]);
        }

        if (scene.name == "Level02")
        {
            Instantiate(Charaters[CharIndex]);
        }
    }



}
