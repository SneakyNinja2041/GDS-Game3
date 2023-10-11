using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class EXPBar : MonoBehaviour
{
    public int currentExp = 0;
    public int maxExp = 10;

    public Slider slider;

    public int level = 0;

    public TextMeshProUGUI levelText;


    private void Start()
    {
        currentExp = 0;
        slider.value = currentExp;
    }

    void Update()
    {
        if (currentExp == maxExp)
        {
            currentExp = 0;
            level++;
        }


        levelText.text = "Level: " + level;
        
    }

    public void TestEXP()
    {
        currentExp++;
        slider.value = currentExp;
    }

}
