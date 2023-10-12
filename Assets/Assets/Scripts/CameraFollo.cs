using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollo : MonoBehaviour
{
    public Transform target1;
    public Transform target2;

    public float smoothing = 5f;
    // public bool followYAxis = true;
    public Vector3 offset = new Vector3(0f, 0f, 0f);

    public bool isTraining;

    void Start()
    {
        isTraining = false;
    }

    private void FixedUpdate()
    {
        if (isTraining = true)
        {
            Vector3 targetPosition = target1.position + offset;
            transform.position = Vector3.Lerp(transform.position, targetPosition, smoothing * Time.fixedDeltaTime);


        }
        else
        {
            Vector3 targetPosition = target2.position + offset;
            transform.position = Vector3.Lerp(transform.position, targetPosition, smoothing * Time.fixedDeltaTime);


        }



    }


}
