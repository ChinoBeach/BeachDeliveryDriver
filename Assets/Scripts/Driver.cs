using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    //Class variables (SerializedFields make it changeable within Unity. Changes made in Unity dont save here)
    [SerializeField] float fltSteerSpeed = 300f;
    [SerializeField] float fltMoveSpeed = 20f;
    [SerializeField] float fltSlowSpeed = 15f;
    [SerializeField] float fltBoostSpeed = 30f;

    private void OnTriggerEnter2D(Collider2D other)
    {
        //if you run over a boost
        if(other.tag == "SpeedUp")
        {
            //apply boost to speed
            fltMoveSpeed = fltBoostSpeed;
            Debug.Log("Boosted!");
        }

        //if you run over a speedbump
        if(other.tag == "SlowDown")
        {
            //apply slowdown to speed
            fltMoveSpeed = fltSlowSpeed;
            Debug.Log("Speed Reduced!");
        }

    }

    // Update is called once per frame
    void Update()
    {
        //Method variables
        float fltSteerAmount = Input.GetAxis("Horizontal") * fltSteerSpeed * Time.deltaTime;
        float fltMoveAmount = Input.GetAxis("Vertical") * fltMoveSpeed * Time.deltaTime;

        //Turn the car (0 x, 0 y, steerAmount z)
        transform.Rotate(0,0,-fltSteerAmount);

        //Move the car forward/backward(0 x, moveSpeed y, 0 z)
        transform.Translate(0,fltMoveAmount,0);
    }
}
