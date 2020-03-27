using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneForse : MonoBehaviour
{
    public float hoverForse = 20f;
    private void OnCollisionStay(Collision collision)
    {
        collision.rigidbody.AddForce(Vector3.up * hoverForse, ForceMode.Acceleration);
    }
}
