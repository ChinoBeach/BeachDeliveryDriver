using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    //variables car colors
    [SerializeField] Color32 hasPackageColor = new Color32(1, 1, 1, 1);
    [SerializeField] Color32 noPackageColor = new Color32(1, 1, 1, 1);
    
    //Variable for changing car color
    SpriteRenderer spriteRenderer;
    
    
    //variable to see if we have picked up the package
    bool bolHasPackage;

    //variable time delay when destorying an object
    [SerializeField] float fltDestoryDelay = 0.5f;

    

    
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    //When two things collide
    void OnCollisionEnter2D(Collision2D other) 
    {
        Debug.Log("Crash!");
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        //IF the trigger is the package
        if(other.tag == "Package" && !bolHasPackage)
        {
            //note that we have the package
            bolHasPackage = true;
            Debug.Log("Package Aquired");

            //change car color
            spriteRenderer.color = hasPackageColor;

            //remove the package from the game 
            Destroy(other.gameObject, fltDestoryDelay);
        }

        //IF the trigger is a cusomer,AND we have the package
        if(other.tag == "Customer" && bolHasPackage == true)
        {
            //note that we no longer have the package
            bolHasPackage = false;
            Debug.Log("Package Delivered");

            //change car color
            spriteRenderer.color = noPackageColor;

        }

    }
}
