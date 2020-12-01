using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    
    void Update()
    {
        animator.SetFloat("Vertical", Input.GetAxis("Vertical"));
        animator.SetFloat("Horizontal", Input.GetAxis("Horizontal"));

        if(Input.GetKeyUp(KeyCode.Space))
        {
            Jump();
        }
    }

    public void Jump()
    {
        animator.SetTrigger("Jump");
    }
}
