using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//this line of code adds automatically the components "rigidbody" and "box collider" to the Player GameObject. 
[RequireComponent(typeof(Rigidbody), typeof(BoxCollider))]
public class PlayerController : MonoBehaviour
{
    //declaration of a variable where is contained the player's rigidbody 
    [SerializeField] private Rigidbody playerRigidBody;
    //declaration of a variable where is contained the Joystick of the game, used for the movement of the player.
    [SerializeField] private FixedJoystick fixedJoystick;
    //declaration of a variable where is contained the value of the speed of movement(of the player.).
    private float speedMovement= 7.5f;

    //we use the fixed update because we will do physics calculus and modify at the rigidbody/box collider of the player.
    private void FixedUpdate()
    {
        //mod of the velocity of the rb with a new pos, the inputs are horizontal and vertical axis of the JoyStick(that are moltiplied for the speed movement)
        playerRigidBody.velocity= new Vector3(fixedJoystick.Horizontal * speedMovement, 0 , fixedJoystick.Vertical * speedMovement);  //horizontal=x value; vertical=z value  (VECTOR WITH 3 DIMENSIONS)

        if ((fixedJoystick.Horizontal != 0) || (fixedJoystick.Vertical!=0))
        {
            transform.rotation= (Quaternion.LookRotation(playerRigidBody.velocity));
        }
    }
}
