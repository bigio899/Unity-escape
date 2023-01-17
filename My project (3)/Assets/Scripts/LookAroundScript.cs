using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class LookAroundScript : MonoBehaviour
{
    private static float mouseSensitivity = 0.4f; //value of the sensitivty of the camera's rotation.
    //in this variable there's the transform component of the father-gameobject of the player.
    [SerializeField] private Transform playerBody;
    private float xRotation = 0;

    //touchscreen axis' variables.
    private float touchscreenInputX = 0.0f;
    private float touchscreenInputY = 0.0f;

    //TOUCHSCREEN AREA
    private Touch theTouch;
    private Vector2 touchStartPosition = new Vector2(0.0f, 0.0f);
    private Vector2 touchEndPosition = new Vector2(0.0f, 0.0f);
    private float axisTouchscreenInputX;
    private float axisTouchscreenInputY;
    // Start is called before the first frame update
    void Start()
    {
       // Cursor.lockState = CursorLockMode.Locked; 
    }

    // Update is called once per frame
    void Update()
    {
        //condition that verify if the engine detects that there's an input on the touchscreen.
        if(Input.touchCount>0)
        {
            theTouch = Input.GetTouch(0); //get the first touch that is detected.
            if (theTouch.position.x >= 600.0f)
            {
                if ((theTouch.phase == TouchPhase.Began) || (theTouch.phase == TouchPhase.Moved)) //verify if the inputs detected from the touchscreen are started.
                {
                    touchStartPosition = theTouch.position;
                }
                if ((theTouch.phase == TouchPhase.Ended))
                {
                    touchEndPosition = theTouch.position;
                }
            }
        }
        //get the information about the axis(input from the touchscreen).
        axisTouchscreenInputX = (touchEndPosition.x - touchStartPosition.x);
        axisTouchscreenInputY = (touchEndPosition.y - touchStartPosition.y);

        //this line of script will get the 'x'movements of the mouse and the result will moltiplied for the 'y' rotation of the father-gameobject(line 24)
        touchscreenInputX = axisTouchscreenInputX * mouseSensitivity * Time.deltaTime;
        touchscreenInputY = axisTouchscreenInputY * mouseSensitivity * Time.deltaTime;

        xRotation = xRotation - touchscreenInputY;
        xRotation = Mathf.Clamp(xRotation, -45.0f, +45.0f); //clamp the max and the minimum value that the varible can contain
        transform.localRotation = Quaternion.Euler(xRotation, 0, 0);
       

        //this part of script will rotate the y value of the rotation of the father-object
        playerBody.Rotate(Vector3.up * touchscreenInputX);
    }
}
