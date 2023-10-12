using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Money : MonoBehaviour
{
    private float speed = 2;

  

    private void Update()
    {
        if (gameObject.transform.position.y < -7)
        {
            Destroy(gameObject);
        }

        transform.Translate(Vector3.down * speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Destroy(this.gameObject);

        }
    }


}
