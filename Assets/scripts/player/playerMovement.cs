using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    Rigidbody rb;
    public float jump = 30;

    public bool isGrounded = true;
    float speed = 8;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        transform.position += move * speed * Time.deltaTime;
        move = transform.position;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            //isGrounded = false;
            Debug.Log("pressed");
            rb.AddForce(Vector3.up * jump, ForceMode.Impulse);
            //rb.velocity = Vector3.up * jump;

        }

        if (isGrounded == false)
        {

        }

        void onCollisionEnter(Collision other)
        {
            if (other.gameObject.CompareTag("Ground"))
            {
                isGrounded = true;
                Debug.Log("grounded");
            }

        }   

    }
}
