using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FanUp : MonoBehaviour
{
    Rigidbody rb;
    public float height;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        Ray fanRay = new Ray(transform.position, Vector3.down);
        if (Physics.Raycast(fanRay, out hit, height))
        {
            //Debug.Log("hit");
            if(hit.collider.tag == "Fan")
            {
                Debug.Log("Fan activate");
                rb.AddForce(Vector3.up * 2f);
            }
        }
    }


}
