using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour
{
    public GameObject shop;
    public bool isOpened;
    
    void Start()
    {
        isOpened = false;
    }

    public void ShopMenu()
    {
        if (isOpened == true)
        {
            shop.SetActive(false);
            isOpened = false;
        }
        else
        {
            shop.SetActive(true);
            isOpened = true;
        }

    }
}
