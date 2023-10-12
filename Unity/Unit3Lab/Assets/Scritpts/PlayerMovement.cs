using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController controller;
    public float speed = 6f;
    public float sprintSpeed = 12f;
    Vector3 velocity;
    public float gravity = -30f;
    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;
    bool isGrounded;
    public float jumpHeight = 2.5f;
    Vector3 standHeight = new Vector3(1f, 1f, 1f);
    Vector3 crouchHeight = new Vector3(1f, 0.5f, 1f);
    bool crouched = false;                               //Declare the variables

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask); //Creating a sphere that checks for collisions with objects on the "Ground" layer to perform the gorund check
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");    //Getting the input from the keyboard
        Vector3 move;   //Creting a vector ths is going to be applied to the Character Controller in order to make it move
        

        if (!Input.GetButton("Crouch"))     //Implementing the crouch functionality by scaling an empty, which is a parent of the charater controller
        {
            transform.localScale = standHeight;
            crouched = false;
        } else 
        {
            transform.localScale = crouchHeight;
            crouched = true;
        }
        
        if(!crouched)   //Checking for crouching. If crouching - divide the character speed by 2
        {
            move = transform.right * x + transform.forward * z;
        } else
        {
            move = (transform.right * x + transform.forward * z) / 2;
        }
        
        if (Input.GetButton("Sprint") && !crouched)     //Checking for shift being pressed and not being crouched. If conditions are met, use the sprint speed
        {
            controller.Move(move * sprintSpeed * Time.deltaTime);
        } else
        {
            controller.Move(move * speed * Time.deltaTime);
        }

        velocity.y += gravity * Time.deltaTime;     //Creating gravity by subtracting the gravity value

        if (isGrounded && velocity.y < 0)   //If grounded, create small gravity to make sure that character is touching the ground
        {
            velocity.y = -2f;
        }
        
        if(Input.GetButtonDown("Jump") && isGrounded && !crouched)  //If not crouched and is grounded, add jumping velocity
        {
            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
        }

        controller.Move(velocity * Time.deltaTime);     //Add the jump velocity to the character controller

        
        
    }
}
