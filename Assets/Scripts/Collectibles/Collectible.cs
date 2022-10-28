using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible : MonoBehaviour
{
    float speed = 70;

    void Update()
    {
        transform.Rotate(25 * Time.deltaTime, speed * Time.deltaTime, 50 * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
    }
}
