using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class birdAnim : MonoBehaviour
{
    enemy nmy;
    Animator animator;
    void Start()
    {
        animator = GetComponent<Animator>();
        nmy = FindObjectOfType<enemy>();
    }

    // Update is called once per frame
    void Update()
    {
        if (animator != null)
        {

            bool attackPlayer = (nmy.attacking);
            animator.SetBool("flyat", attackPlayer);

        }
    }
}
