using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextTimer : MonoBehaviour
{

    private float deathDelay = 30f;

    void Start()
    {
        Destroy(gameObject, deathDelay);
    }

}
