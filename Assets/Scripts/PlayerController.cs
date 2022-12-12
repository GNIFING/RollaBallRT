using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float speed;
    private Rigidbody rb;

    private float movementX;
    private float movementY;

    public Material plastic;
    public Material metal;

    public Vector3 startPosition;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        startPosition = transform.position;
    }

    // Update is called once per frame
    private void Update()
    {
        movementX = Input.GetAxisRaw("Horizontal");
        movementY = Input.GetAxisRaw("Vertical");

        if (Input.GetKeyDown("space"))
        {
            if (rb.mass == 1)
            {
                rb.mass = 1000;
                GetComponent<Renderer>().material = metal;
            }
            else
            {
                rb.mass = 1;
                GetComponent<Renderer>().material = plastic;
            }
        }

    }
    void FixedUpdate()
    {
        Vector3 movement = new Vector3(movementX, 0f, movementY);
        rb.AddForce(movement * speed * rb.mass);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Reset"))
        {
            this.transform.position = startPosition;
        }
    }

}
