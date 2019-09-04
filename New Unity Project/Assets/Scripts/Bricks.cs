using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Bricks : MonoBehaviour
{
    /*public Color GreenColor;
    public Color CyanColor;*/

    public GameObject brickParticle;

    void OnCollisionEnter(Collision other)
    {
        Instantiate(brickParticle, transform.position, Quaternion.identity);
        GM.instance.DestroyBrick();

        Destroy(gameObject);

       /* if (other.gameObject.CompareTag("Ball"))
        {
            transform.GetComponent<Renderer>().material.color = GreenColor;
        }
        */
    }
}