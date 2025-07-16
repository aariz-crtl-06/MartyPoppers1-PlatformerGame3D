using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    Rigidbody rb;
    public float jump = 10;
    public float gravityScale = 0.8f;
    public float fallingGravityScale = 30f;
    float currentGravityScale;

    public bool isGrounded;
    float speed = 8;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        currentGravityScale = gravityScale;
    }

    private void FixedUpdate() => rb.AddForce(Physics.gravity * (gravityScale - 1) * rb.mass);

    void Update()
    {
        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        transform.position += move * speed * Time.deltaTime;
        move = transform.position;

        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            Debug.Log("pressed");
            rb.AddForce(Vector3.up * jump, ForceMode.Impulse);

        }

        if (rb.velocity.y >= 0)
        {
            currentGravityScale = gravityScale;
        }
        else
        {
            currentGravityScale = fallingGravityScale;

        }

    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        isGrounded = false;

    }


}
