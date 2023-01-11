using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRig : MonoBehaviour
{
    //variable that take the transform element of the player.
    [SerializeField] private Transform transTarget; //this variable takes only the player's head because if we take all the player,the camera appears in the middle of the body.
    void Update()
    {
        //the transform position of the camera becomes the transform position of the transform position of the player
        transform.position = transTarget.position;
        
    }
}