using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerStats : MonoBehaviour
{
    public static int money;
    public int startMoney = 0;

    public TextMeshProUGUI moneyText;

    [SerializeField] GameObject expBar;
    EXPBar exp;

    void Start()
    {
        money = startMoney;
        exp = expBar.GetComponent<EXPBar>();
    }

    void Update()
    {
        moneyText.text = "Money: $" + money.ToString();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Money"))
        {
            exp.ExpUp();

            money++;
        }

    }
}
