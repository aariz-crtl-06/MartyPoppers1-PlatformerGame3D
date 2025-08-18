using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerUi : MonoBehaviour
{
    playerHealth playerHealth;
    public float healthy;
    public float maxHealth =4;

    public Sprite emptyHeart;
    public Sprite fullHeart;
    public Image[] hearts;
    void Start()
    {
        playerHealth = GetComponent<playerHealth>();
    }

    void Update()
    {
        healthy = playerHealth.health; 

        for (int i = 0; i < hearts.Length; i++)
        {
            if( i < healthy)
            {
                hearts[i].sprite = fullHeart;
            }
            
            else
            {
                hearts[i].sprite = emptyHeart;
            }

            if(i < maxHealth)
            {
                hearts[i].enabled = true;
            }

            else
            {
                hearts[i].enabled = false;
            }
        }
    }
}
