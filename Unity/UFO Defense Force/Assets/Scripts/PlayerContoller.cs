using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerContoller : MonoBehaviour
{
    //Create Varibales for the player movement input
    public float horizontalInput;
    public float speed = 20f;
    public float xRange = 25f;

    //Create Variables for the projectile spawning
    public Transform blaster;
    public GameObject laserBolt;

    //Delete the objects that collide with the player
    private void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        //Update the value of the input
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
        //Constrain the movement to a range
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }

        //Instantiate the laser bolt
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(laserBolt, blaster.transform.position, laserBolt.transform.rotation);
        }

        
    }
}
