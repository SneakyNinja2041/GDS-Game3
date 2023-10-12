using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollo : MonoBehaviour
{
    public Transform target1;

    public float smoothing = 5f;
    public Vector3 offset = new Vector3(0f, 0f, 0f);

    private void FixedUpdate()
    {
            Vector3 targetPosition = target1.position + offset;
            transform.position = Vector3.Lerp(transform.position, targetPosition, smoothing * Time.fixedDeltaTime);
    }



}
