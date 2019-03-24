using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextPillar : MonoBehaviour
{

    public Animator Animator1;
    public Animator Animator2;
    public string WhatAnimation; 

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Animator1.enabled = true;
            Animator1.Play(WhatAnimation); 
            Animator2.enabled = true;
        }
    }

}