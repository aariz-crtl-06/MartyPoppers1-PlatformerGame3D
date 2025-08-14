using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class playerMovement : MonoBehaviour
{

    public bool falling = false;
    Rigidbody rb;
    public float jump = 10;
    public float gravityScale = 2;
    
    public bool isGrounded;
    public bool isOnBoost;
    public float speed = 8;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        
    }

    private void FixedUpdate() => rb.AddForce(Physics.gravity * (gravityScale - 1) * rb.mass);

    void Update()
    {
        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));

        if (move != Vector3.zero)
        {
            // Smoothly rotate toward movement direction
            Quaternion targetRotation = Quaternion.LookRotation(move, Vector3.up);
            transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, Time.deltaTime * 10f);
        }

        transform.position += move * speed * Time.deltaTime;
        move = transform.position;

        //When jumped
        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            rb.AddForce(Vector3.up * jump, ForceMode.Impulse);

        }

        //Got on to boost pad
        if (Input.GetButtonDown("Jump") && isOnBoost)
        {
            speed = 18;
            jump = 20;
            rb.AddForce(Vector3.up * jump, ForceMode.Impulse);

        }

        if (rb.velocity.y < 0 && Input.GetButton("Jump"))
        {
            gravityScale = 0.1f;
            falling = true;
        }
        else
        {
            gravityScale = 2;
            falling = false;
        }

        if(Input.GetButton("Sprint") && isGrounded)
        {
            speed = 16;
            jump = 15;
        }   

        else
        {
            speed = 8;
            jump = 10;
        }

    }

    

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
           
        }

        if(other.gameObject.CompareTag("Boost"))
        {
            isOnBoost = true;
        }
    }

    private void OnCollisionExit(Collision other)
    {
        isGrounded = false;

        isOnBoost = false;

    }


}
