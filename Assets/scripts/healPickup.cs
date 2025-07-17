using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class healPickup : MonoBehaviour
{
    playerHealth playerhealth;
    void Start()
    {
        playerhealth = FindObjectOfType<playerHealth>();

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
            if (playerhealth.health < 100)
            {
                playerhealth.health += 25;
                Destroy(gameObject);

                if (playerhealth.health > 100)
                {
                    playerhealth.health = 100;
                }
            }
        
        }
    }
}
