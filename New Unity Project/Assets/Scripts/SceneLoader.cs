using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine. SceneManagement;

public class SceneLoader : MonoBehaviour
{

    //public static SceneLoader instance = null;

    private void Awake()
    {/*
        DontDestroyOnLoad(gameObject);

        if(instance == null)
        {
            instance = this;

        }
        else if(instance != this)
        {
            Destroy(gameObject);
        }

        */
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Quit()
    {
        Application.Quit();
    }
    public void LoadBreakoutGame()
    {
        SceneManager.LoadScene(1);
    }

}
