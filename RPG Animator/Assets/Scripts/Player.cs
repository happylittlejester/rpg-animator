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

        if(Input.GetKeyUp(KeyCode.LeftShift))
        {
            Run();
        }
    }

    public void Jump()
    {
        animator.SetTrigger("Jump");
    }

    public void Run()
    {
        animator.SetTrigger("Run");
    }
}
