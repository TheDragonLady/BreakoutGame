﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GM : MonoBehaviour
{
    public int lives = 3;
    public int bricks = 42;
    public float resetDelay = 1f;
    public Text livesText;
    public GameObject gameOver;
    public GameObject youWon;
    public GameObject bricksPrefab;
    public GameObject Paddle;
    public GameObject deathParticles;
    public static GM instance = null;

    private GameObject clonePaddle;

    // Start is called before the first frame update
    void Awake()
    {
        if (instance == null)
            instance = this;
        else if (instance != this)
            Destroy(gameObject);

        Setup(); 
    }

    public void Setup()
    {
        clonePaddle = Instantiate(Paddle, transform.position, Quaternion.identity) as GameObject;
        Instantiate(bricksPrefab, transform.position, Quaternion.identity);
       
    }

    void CheckGameOver()
    {
        if (bricks < 1)
        {
            youWon.SetActive(true);
            Time.timeScale = .25f;
            Invoke("Reset", resetDelay);
        }
        if (lives <1)
        {
            gameOver.SetActive(true);
            Time.timeScale = .25f;
            Invoke("Reset", resetDelay);
        }
       
    }

    void Reset()
    {
        Time.timeScale = 1f;
        Application.LoadLevel(Application.loadedLevel);
    }
    
    public void LoseLife()
    {
        lives--;
        livesText.text = "Lives: " + lives;
        Instantiate(deathParticles, clonePaddle.transform.position, Quaternion.identity);
        Destroy(clonePaddle);
        Invoke("SetupPaddle", resetDelay);
        CheckGameOver();
    }

    void SetupPaddle()
    {
        clonePaddle = Instantiate(Paddle, transform.position, Quaternion.identity) as GameObject;
        
    }

    public void DestroyBrick()
    {
        bricks--;
        CheckGameOver();
    }
}

