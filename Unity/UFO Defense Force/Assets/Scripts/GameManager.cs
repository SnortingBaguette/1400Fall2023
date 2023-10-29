using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public bool isGameOver;
    private GameObject gameOverText;

    private void Awake()
    {
        Time.timeScale = 1;
        isGameOver = false;
    }
    // Start is called before the first frame update
    void Start()
    {
        gameOverText = GameObject.Find("GameOverText");
    }

    // Update is called once per frame
    void Update()
    {
        if (isGameOver) 
        {
            EndGame(); //Call the EndGame method
        } else
        {
            gameOverText.gameObject.SetActive(false); //Keep the text hidden
        }
    }

    public void EndGame()
    {
        gameOverText.gameObject.SetActive(true); //Make the text visible
        Time.timeScale = 0; //Set time scale to 0
    }
}
