using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePickupSpawn : MonoBehaviour
{

    public float xRange = 25f;
    public float speed = 20f;
    public int horizontalInput = 1;
    bool moveRight;
    public int pickupNumber = 0;


    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < -xRange)
        {
            moveRight = true;
        }
        if (transform.position.x > xRange)
        {
            moveRight = false;
        }

        if (moveRight)
        {
            transform.Translate(Vector3.right * horizontalInput * speed * Time.deltaTime);
        } else if (!moveRight)
        {
            transform.Translate(Vector3.right * -horizontalInput * speed * Time.deltaTime);
        }
    }
}
