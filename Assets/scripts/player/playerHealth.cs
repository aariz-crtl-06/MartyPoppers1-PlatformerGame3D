using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerHealth : MonoBehaviour
{
    public GameObject gameOverScreen;
    public float health;
    void Start()
    {
        health = 4f;
    }

    void Update()
    {
        if(health <= 0)
        {
            Die();
        }
    }

    public void Die()
    {
        gameOverScreen.SetActive(true);
    }
   
}
