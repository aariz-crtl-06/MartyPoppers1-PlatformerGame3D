using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    Rigidbody rb;
    public float jump = 3;
    float speed = 8;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        transform.position += move * speed * Time.deltaTime;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("pressed");
            rb.AddForce(new Vector3 (rb.velocity.x, jump, speed));
        }

    }
}
