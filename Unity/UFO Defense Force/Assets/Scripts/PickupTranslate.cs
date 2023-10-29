using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupTranslate : MonoBehaviour
{
    //Create the necessary variables
    public float speed = -15f;
    public int pickupNumber = 0;
    public float lowerBounds = -20f;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
        if (transform.position.z < lowerBounds)
        {
            Destroy(gameObject);
        }
    }
}
