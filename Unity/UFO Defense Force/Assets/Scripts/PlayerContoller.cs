using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerContoller : MonoBehaviour
{
    //Create Varibales for the player movement input
    public float horizontalInput;
    public float speed = 30f;
    public float xRange = 25f;

    //Create Variables for the projectile spawning
    public Transform blaster;
    public GameObject laserBolt;

    //Create a reference for the pickup object
    public GameObject pickup;
    public Transform pickupSpawn;

    //Create pickup counter variables
    public int pickupNumber = 0;

    public GameManager gameManager;


    private void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>(); //Reference GameManager script on GameManager object

    }

    //Delete the objects that collide with the player and print a message
    private void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
        pickupNumber++;
        Debug.Log("You have picked up " + pickupNumber + " items!");
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

        //Instantiate the laser bolt if the game isn't over
        if (Input.GetKeyDown(KeyCode.Space) && gameManager.isGameOver == false)
        {
            Instantiate(laserBolt, blaster.transform.position, laserBolt.transform.rotation);
            FindObjectOfType<AudioManager>().Play("ShootingSound");
        }
    }

    private void FixedUpdate()
    {
        //Create a random number
        int randomNumber = Random.Range(0, 1000);

        //Instatiate the pickup based on the random number
        if (randomNumber <= 5)
        {
            Instantiate(pickup, pickupSpawn.transform.position, pickup.transform.rotation);
        }
    }
}
