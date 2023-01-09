using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRig : MonoBehaviour
{
    [SerializeField]
    Transform transTarget;

    void Update()
    {
        transform.position = transTarget.position;
    }
}