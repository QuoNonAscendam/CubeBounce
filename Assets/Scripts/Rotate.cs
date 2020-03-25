using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    Quaternion originRotation;
    float angle;

    void Start()
    {
        originRotation = transform.rotation;
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        angle++;

        Quaternion rotationY = Quaternion.AngleAxis(angle, Vector3.up);
        Quaternion rotationX = Quaternion.AngleAxis(angle*10, Vector3.right);

        transform.rotation = originRotation * rotationY * rotationX;

        
    }
}
