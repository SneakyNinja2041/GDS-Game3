using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cosmetics : MonoBehaviour
{
    public GameObject defaultBG;
    public GameObject parkBG;
    public GameObject fallBG;
    public GameObject desertBG;
    public GameObject hellBG;

    public bool isDefault;
    public bool isPark;
    public bool isFall;
    public bool isDesert;
    public bool isHell;

    void Start()
    {
        isDefault = true;
        isPark = false;
        isFall = false;
        isDesert = false;
        isHell = false;
    }

    public void SwapDefault()
    {
        isDefault = true;
        isPark = false;
        isFall = false;
        isDesert = false;
        isHell = false;

    }

    public void SwapPark()
    {
        isDefault = false;
        isPark = true;
        isFall = false;
        isDesert = false;
        isHell = false;
    }

    public void SwapFall()
    {
        isDefault = false;
        isPark = false;
        isFall = true;
        isDesert = false;
        isHell = false;
    }

    public void SwapDesert()
    {
        isDefault = false;
        isPark = false;
        isFall = false;
        isDesert = true;
        isHell = false;
    }

    public void SwapHell()
    {
        isDefault = false;
        isPark = false;
        isFall = false;
        isDesert = false;
        isHell = true;
    }

    void Update()
    {
        if (isDefault == true)
        {
            defaultBG.SetActive(true);
        }
        else
        {
            defaultBG.SetActive(false);
        }

        if (isPark == true)
        {
            parkBG.SetActive(true);
        }
        else
        {
            parkBG.SetActive(false);
        }

        if (isFall == true)
        {
            fallBG.SetActive(true);
        }
        else
        {
            fallBG.SetActive(false);
        }

        if (isDesert == true)
        {
            desertBG.SetActive(true);
        }
        else
        {
            desertBG.SetActive(false);
        }

        if (isHell == true)
        {
            hellBG.SetActive(true);
        }
        else
        {
            hellBG.SetActive(false);
        }
    }

}
