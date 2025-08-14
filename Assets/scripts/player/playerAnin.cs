using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class playerAnin : MonoBehaviour
{
    playerMovement aPlayerMovement;

    public GameObject brella;
    public GameObject attackBrella;
    public float attackDuration = 1.2f;
    private float attackTimer = 0f;
    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();

        aPlayerMovement = FindObjectOfType<playerMovement>();
    }

    // Update is called once per frame
    void Update()
    {


        if (animator != null)
        {

            bool idle = (aPlayerMovement.falling);
            animator.SetBool("testy", idle);

            bool isWalking = (Input.GetAxisRaw("Horizontal") != 0 || Input.GetAxisRaw("Vertical") != 0 && idle!=true);
            animator.SetBool("theWalk", isWalking);

            bool isAttacking = Input.GetButtonDown("Attack");
            animator.SetBool("attack", isAttacking);

      
            if (Input.GetButtonDown("Attack"))
            {
                attackTimer = attackDuration;
                animator.SetBool("attack", true);
                attackBrella.SetActive(true);
            }

            if (attackTimer > 0)
            {
                attackTimer -= Time.deltaTime;
            }
            else
            {
                animator.SetBool("attack", false);
                attackBrella.SetActive(false);
            }

            if (aPlayerMovement.falling)
            {
                brella.SetActive(true);
                isWalking = false;
            }

            if(idle == false)
            {
                brella.SetActive(false);
            }

            if(brella.activeSelf)
            {
                attackBrella.SetActive(false);
            }

            if (attackBrella.activeSelf)
            {
                brella.SetActive(false);
            }
        }
      
    }
}
