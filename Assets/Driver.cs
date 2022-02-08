using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    //Class variables (SerializedFields make it changeable within Unity. Changes made in Unity dont save here)
    [SerializeField] float steerSpeed = 300f;
    [SerializeField] float moveSpeed = 20f;

    // Start is called before the first frame update
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {
        //Method variables
        float steerAmount = Input.GetAxis("Horizontal") * steerSpeed * Time.deltaTime;
        float moveAmount = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;

        //Turn the car (0 x, 0 y, steerAmount z)
        transform.Rotate(0,0,-steerAmount);

        //Move the car forward/backward(0 x, moveSpeed y, 0 z)
        transform.Translate(0,moveAmount,0);
    }
}
