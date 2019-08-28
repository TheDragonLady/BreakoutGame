using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    public float paddleSpeed = 1f;

    private Vector3 playerPos = new Vector3(0, -9.5f, 0);

    

    // Update is called once per frame
    void Update()
    {
        float xPos = transform.position.x + (Input.GetAxis("Horizontal") * paddleSpeed);
        playerPos = new Vector3 (Mathf.Clamp (xPos, -8f, 8f), -9.5f, 0f);
        transform.position = playerPos;


    }

    /*private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "ball")
        {
            Rigidbody rb = collision.gameObject.GetComponent<Rigidbody>();
            GameObject ball = collision.gameObject;

            float collisionPosition = collision.transform.position.z;
            float centerpoint = transform.position.z;

            float magnitude = rb.velocity.magnitude;

            float oppositeLength = (collisionPosition - centerpoint);

            float rotation = Mathf.Atan( oppositeLength/ adjacentLength ) * Mathf.Rad2Deg;

            ball.transform.rotation = Quaternion.Euler(0, rotation - 90, 0);

            rb.velocity = ball.transform.forward * magnitude;
        }
    }*/

}
