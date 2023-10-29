using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{

    public float topBounds = 30f;
    public float lowerBounds = -20f;

    private void Awake()
    {
        Time.timeScale = 1.0f;
    }
    // Update is called once per frame
    void Update()
    {
        //Check for position out of bounds. If is lower/higher, then destroy the object
        if (transform.position.z < lowerBounds)
        {
            Destroy(gameObject);
            Debug.Log("Game Over");
            Time.timeScale = 0f;
        } else if (transform.position.z > topBounds)
        {
            Destroy(gameObject);
        }
    }
}
