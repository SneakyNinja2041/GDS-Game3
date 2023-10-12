using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class EXPBar : MonoBehaviour
{
    public int exp;
    public int maxExp = 10;

    public Slider slider;

    public int level = 0;

    public TextMeshProUGUI levelText;


    private void Start()
    {
        exp = 0;
    }

    void Update()
    {
        if (exp == maxExp)
        {
            exp = 0;
            level++;
        }


        levelText.text = "Level: " + level;

    }

    public void SetMaxExp(int exp)
    {
        slider.value = exp;
        slider.maxValue = maxExp;
    }

    public void ExpUp()
    {
        exp += 2;
        slider.value = exp;
    }

}
