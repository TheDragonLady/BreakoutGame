using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
     public float ballInitialVelocity = 500f;

     private Rigidbody rb;
     private bool ballInPlay;
    


    // Start is called before the first frame update
    void Awake()
     {
         rb = GetComponent <Rigidbody> ();
     }

     // Update is called once per frame
     void Update()
     {
        

        if (Input.GetButtonDown("Fire1") && ballInPlay == false)
        {
            transform.parent = null;


            Ray mouseRay = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(mouseRay, out hit))
            {
                Vector3 lookAtThisPoint = new Vector3(hit.point.x, hit.point.y, 0);
                transform.LookAt(lookAtThisPoint);
                
            }


            ballInPlay = true;
            rb.isKinematic = false;
            rb.AddForce(transform.forward * ballInitialVelocity);


        }
       
     }
     

}

