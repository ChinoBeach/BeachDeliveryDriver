using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    //When two things collide
    void OnCollisionEnter2D(Collision2D other) 
    {
        Debug.Log("Crash!");
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        //IF the trigger is the package, print "package aquired" to he console
        if(other.tag == "Package")
        {
            Debug.Log("Package Aquired");
        }

        //IF the trigger is a cusomer, print "package delivered" to the console
        if(other.tag == "Customer")
        {
            Debug.Log("Package Delivered");
        }

    }
}
