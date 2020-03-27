using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class CountBounce : MonoBehaviour
{
    int CountPlane = 0;
    public GameObject plane;
    float Distance = 0f;
    public Text CountAndDistance;
    int CountCube = 0;
    private void OnCollisionEnter(Collision collision)
    {
        CountPlane++;
    }
    private void OnTriggerExit(Collider other)
    {
        CountCube++;
    }
    private void FixedUpdate()
    {
        Distance = transform.position.y - plane.transform.position.y;

        CountAndDistance.text = "CountPlane " + CountPlane + " CountCube " + CountCube + "\nDistance " + Distance;
    }
}
