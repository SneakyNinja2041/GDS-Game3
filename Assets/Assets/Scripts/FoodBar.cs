using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class FoodBar : MonoBehaviour
{
    public Slider slider;

    public GameObject gameOverUI;
    public float gameTime;
    public int startTime = 5;

    public float timer;

    public int food;
    public int startFood = 0;
    public TextMeshProUGUI foodText;

    void Awake()
    {
        gameTime = startTime;
        food = startFood;
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

        foodText.text = "Food: " + food.ToString();

    }

    public void Feed()
    {
        if (food >= 1)
        {
            food--;
            timer = gameTime += 30;
        }
    }

    public void BuyFood()
    {
        if (PlayerStats.money >= 10)
        {
            PlayerStats.money -= 10;
            food++;
        }

    }


}
