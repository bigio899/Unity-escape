using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private CharacterController playerController; //reference to our character controller(motor that drives our player).
    private static float speedOfTheMovement = 0.025f; //speed of the movement of the player
    private static float gravityNumber = (-9.81f * 2.5f); //this number is negative.
    private float jumpHeight = 2.0f;

    [SerializeField] private Transform groundCheckerGameObjectTransform;
    private static float groundDistance = 0.4f;
    [SerializeField] private LayerMask groundMask; //control what objects this scene would check for.

    private Vector3 velocity;
    private bool isPlayerGrounded; 

    // Start is called before the first frame update
    private void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
        //                    |sphere creation|     |position of sphere|               |radius of sphere||check if the sphere is collided to the ground|
        isPlayerGrounded = Physics.CheckSphere(groundCheckerGameObjectTransform.position, groundDistance, groundMask);

        //verify if the player is on ground and if the pod of velocity of falling down is less than 0.
        if((isPlayerGrounded==true) && (velocity.y< 0))
        {
            velocity.y = -2.0f; //it will set the pos of velocity's vector to -2.

        }
        //get the axis of the movement.
        float xPositionTransform = Input.GetAxis("Horizontal");
        float zPositionTransform = Input.GetAxis("Vertical");

        //direction that we want to do. this is a sum of vectors 
        Vector3 movementPosition = transform.right * xPositionTransform + transform.forward * zPositionTransform;
        //this line of code will do the movement of the player,having the 'movementposition' vector(that have the values of the direction that we want to do).
        //this vector is molitiplied by speed.
        playerController.Move(movementPosition * speedOfTheMovement); //this function can be used only with a charactercontroller object.

        if ((isPlayerGrounded == true) && (Input.GetButtonDown("Jump")))
        {
            //velocity occurred for do the jump of the player
            velocity.y = Mathf.Sqrt(jumpHeight * (-2.0f * gravityNumber)); //square root (formule of a jump).
        }
        velocity.y += gravityNumber * Time.deltaTime; //we apply the gravity force to the y value of transform position of the playercontroller.
        //in this line of code there's the function that apply the gravity to the player gameobject.
        playerController.Move(velocity * Time.deltaTime);
    }
}
