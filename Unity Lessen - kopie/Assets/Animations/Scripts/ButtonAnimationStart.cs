using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonAnimationStart : MonoBehaviour
{

    public Animator Animator;
    public Transform PlayerTransform; 



    // Start is called before the first frame update
    void Start()
    {
        Animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetButtonDown("Interact") && Vector3.Distance(transform.position, PlayerTransform.position) < 3f)
        {


            Animator.enabled = true; 
            Animator.Play("Button"); 
        }
    }

    



    void DisableAnimator()
    {
        Animator.Play("Idle"); 
    }
}
