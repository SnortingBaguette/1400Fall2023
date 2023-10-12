using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{

    public float mouseSensitivity = 300f;
    public Transform playerBody;
    float xRotation = 0f;   //Declare the needed variables
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;   //Hide the coursor when is play mode
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;    //Get the mouse input
        xRotation -= mouseY;    //Rotate the camera over the local X-Axis
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);      //Clamp the rotation to avoid looking up and down too far

        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);  //Apply the rotation
        playerBody.Rotate(Vector3.up * mouseX);     //Rotate the player body over the Y-Axis
    
    }
}
