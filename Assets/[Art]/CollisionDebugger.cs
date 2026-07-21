using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDebugger : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name != "Cube (1)")
        {
            Debug.Log("HIT: " + collision.gameObject.name);
        }
    }

    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if (hit.gameObject.name != "Cube (1)")
        {
            Debug.Log("CONTROLLER HIT: " + hit.gameObject.name);
        }
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }
}