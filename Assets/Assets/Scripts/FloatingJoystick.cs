using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloatingJoystick : MonoBehaviour
{
    public RectTransform Knob;
    public RectTransform RectTransform;

    private void Awake()
    {
        RectTransform = GetComponent<RectTransform>();
    }
}
