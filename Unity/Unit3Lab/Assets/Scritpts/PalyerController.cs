using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class PalyerController : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 5f;
    [SerializeField] private float jumpForce = 5f;
    [SerializeField] private float gravity = 9.81f;
    private CharacterController controller;
    private Vector3 moveDirection;
    private bool isJumping;

    // Start is called before the first frame update
    void Start()
    {
        
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        

        if (Input.GetButtonDown("Jump") && !isJumping)
        {
            
            moveDirection.y = jumpForce;
            isJumping = true;
        } else
        {
            isJumping = false;
        }
        

        Debug.Log(isJumping);
        moveDirection.x = horizontalInput * moveSpeed;
        moveDirection.z = verticalInput * moveSpeed;

        controller.Move(moveDirection * Time.deltaTime);
    }

    private void FixedUpdate()
    {
        if (controller.isGrounded)
        {
            isJumping = false;
        }
        else
        {
            isJumping = true;
            moveDirection.y -= gravity;
        }

    }
}
