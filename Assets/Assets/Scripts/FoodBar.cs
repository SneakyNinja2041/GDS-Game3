using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FoodBar : MonoBehaviour
{
    public Slider slider;

    public GameObject gameOverUI;
    public float gameTime;
    public int startTime = 5;

    public float timer;

    void Awake()
    {
        gameTime = startTime;
    }

    void Start()
    {
        slider.maxValue = gameTime;
        slider.value = gameTime;
        Time.timeScale = 1f;
       
    }




    
    void Update()
    {
        timer = gameTime - Time.time;

        slider.value = timer;
       
        if (timer <= 0)
        {
            gameOverUI.SetActive(true);
            Time.timeScale = 0f;
        }

    }

    public void LoadScene()
    {
        Time.timeScale = 1f;
        gameTime = startTime;
        Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(scene.name);
    }

    public void TimerUp()
    {
        timer = gameTime += 20;
    }
}
