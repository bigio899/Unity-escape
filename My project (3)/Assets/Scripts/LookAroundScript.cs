using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAroundScript : MonoBehaviour
{
    private static float mouseSensitivity = 500.0f; //value of the sensitivty of the camera's rotation.
    //in this variable there's the transform component of the father-gameobject of the player.
    [SerializeField] private Transform playerBody;
    private float xRotation = 0;

    // Start is called before the first frame update
    void Start()
    {
       // Cursor.lockState = CursorLockMode.Locked; 
    }

    // Update is called once per frame
    void Update()
    {
        //this line of script will get the 'x'movements of the mouse and the result will moltiplied for the 'y' rotation of the father-gameobject(line 24)
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;
        xRotation = xRotation - mouseY;
        xRotation = Mathf.Clamp(xRotation, -90.0f, +90.0f); //clamp the max and the minimum value that the varible can contain
        transform.localRotation = Quaternion.Euler(xRotation, 0, 0);
         //this part of script will rotate the y value of the rotation of the father-object
        playerBody.Rotate(Vector3.up * mouseX);
    }
}
