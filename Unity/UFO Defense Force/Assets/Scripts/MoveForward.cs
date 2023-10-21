using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    public float speed = 50f;
 

    // Update is called once per frame
    void Update()
    {
        //Move the projectile in the local Y-axis
        transform.Translate(Vector3.up * speed * Time.deltaTime);
    }
}
