using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class charCtrlr : MonoBehaviour
{
    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.B))
        {
            animator.SetTrigger("burpees");
        }

        if (Input.GetKeyDown(KeyCode.C))
        {
            animator.SetTrigger("crossJump");
        }

        if (Input.GetKeyDown(KeyCode.J))
        {
            animator.SetTrigger("jumpingJacks");
        }

        if (Input.GetKeyDown(KeyCode.K))
        {
            animator.SetTrigger("kettlebellSwing");
        }
    }
}
