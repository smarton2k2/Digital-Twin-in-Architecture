using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pointer : MonoBehaviour
{    
    public Camera targetCamera;
 
    void Update() 
    {
        transform.LookAt(transform.position + targetCamera.transform.rotation * Vector3.right,
        targetCamera.transform.rotation * Vector3.up);
    }
}

