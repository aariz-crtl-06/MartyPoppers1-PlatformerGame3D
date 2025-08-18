using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class endgame : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Player")
        {
            Debug.Log("You win!");
            // Implement endgame logic here, such as displaying a victory screen or stopping the game.
        }
    }

}
