using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    //When two things collide
    void OnCollisionEnter2D(Collision2D other) 
    {
        Debug.Log("Crash!");
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Passed Blue Mark!");   
    }
}
