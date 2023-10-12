using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerOutfit : MonoBehaviour
{
    public GameObject monicle;
    public GameObject devil;
    public GameObject angel;
    public GameObject tophat;
    public GameObject crown;

    public bool isMonicle;
    public bool isDevil;
    public bool isAngel;
    public bool isTophat;
    public bool isCrown;

    void Start()
    {
        isMonicle = false;
        isDevil = false;
        isAngel = false;
        isTophat = false;
        isCrown = false;
    }

    public void SwapMonicle()
    {
        isMonicle = true;
        isDevil = false;
        isAngel = false;
        isTophat = false;
        isCrown = false;
    }

    public void SwapDevil()
    {
        isMonicle = false;
        isDevil = true;
        isAngel = false;
        isTophat = false;
        isCrown = false;
    }

    public void SwapAngel()
    {
        isMonicle = false;
        isDevil = false;
        isAngel = true;
        isTophat = false;
        isCrown = false;
    }

    public void SwapTophat()
    {
        isMonicle = false;
        isDevil = false;
        isAngel = false;
        isTophat = true;
        isCrown = false;
    }

    public void SwapCrown()
    {
        isMonicle = false;
        isDevil = false;
        isAngel = false;
        isTophat = false;
        isCrown = true;
    }

    void Update()
    {
        if (isMonicle == true)
        {
            monicle.SetActive(true);
        }
        else
        {
            monicle.SetActive(false);
        }

        if (isDevil == true)
        {
            devil.SetActive(true);
        }
        else
        {
            devil.SetActive(false);
        }

        if (isAngel == true)
        {
            angel.SetActive(true);
        }
        else
        {
            angel.SetActive(false);
        }

        if (isTophat == true)
        {
            tophat.SetActive(true);
        }
        else
        {
            tophat.SetActive(false);
        }

        if (isCrown == true)
        {
            crown.SetActive(true);
        }
        else
        {
            crown.SetActive(false);
        }

    }





}
