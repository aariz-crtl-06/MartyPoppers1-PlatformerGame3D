using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class healPickup : MonoBehaviour
{
    playerHealth playerhealth;
    playerMovement pm;
    void Start()
    {
        playerhealth = FindObjectOfType<playerHealth>();
        pm = FindObjectOfType<playerMovement>();
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Player Health: " + playerhealth.health);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            pm.isGrounded=true;
            if (playerhealth.health < 4)
            {
                playerhealth.health += 1;
                Destroy(gameObject);

                if (playerhealth.health > 4)
                {
                    playerhealth.health = 4;
                }
            }
        
        }
    }
}
