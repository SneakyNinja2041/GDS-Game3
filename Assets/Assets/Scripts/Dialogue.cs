using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dialogue : MonoBehaviour
{
    [SerializeField] GameObject dialogue0; //Your text objects
    [SerializeField] GameObject dialogue1;
    // you would copy/paste these, with how many pieces of dialogue, just changing the number at the end

    public int dialogue; // this will keep track of what dialogue we are on
    public int startDialogue = 0; // this is to make sure that when you start your scene, you are on the right dialogue

    void Start()
    {
        dialogue = startDialogue;
    }

    void Update()
    {
        if (dialogue == 0)
        {
            dialogue0.SetActive(true);
        }
        else
        {
            dialogue0.SetActive(false);
        }

        if (dialogue == 1)
        {
            dialogue1.SetActive(true);
        }
        else
        {
            dialogue1.SetActive(false);
        }
        // continue down with all of your pieces of dialogue
    }

    public void ChangeDialogue() // connect this to your button to skip dialogue
    {
        dialogue++; // This will add one to the dialogue count, thus changing what dialogue will be displayed
    }
}
