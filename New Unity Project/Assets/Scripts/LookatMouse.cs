using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookatMouse : MonoBehaviour
{
    public float magnitudeFloat = 0.5f;
    public GameObject plane;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void MakeCHaracterLookAtMouse()
    {
        Ray mouseRay = Camera.main.ScreenPointToRay(Input.mousePosition);
        float midPoint = (transform.position - Camera.main.transform.position).magnitude * 0.5f;
        transform.LookAt(mouseRay.origin + mouseRay.direction);
    }


    // Update is called once per frame
    void Update()
    {
        Ray mouseRay = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        
        if(Physics.Raycast(mouseRay, out hit))
        {
            Vector3 lookAtThisPoint = new Vector3(hit.point.x, hit.point.y, 0);
            transform.LookAt(lookAtThisPoint);
            plane.transform.position = lookAtThisPoint;
        }




        

        //transform.LookAt(Camera.main.ScreenToWorldPoint(Input.mousePosition));
    }
}
