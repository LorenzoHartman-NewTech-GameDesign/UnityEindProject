using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextPillar : MonoBehaviour
{

    public Animator Animator1;
    public Animator Animator2;
    public string WhatAnimation;
    //public bool HasPillarRisenUp = false;

    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "Player")
        {

            if (Animator1 != null)
            {
                Animator1.enabled = true;
                Animator1.Play(WhatAnimation);
                //HasPillarRisenUp = true;
            }

            if (Animator2 != null)
            {
                Animator2.enabled = true;
                //HasPillarRisenUp = true;
            }

        }
    }








//private void OnTriggerEnter(Collider other)
//    {
//        if (other.gameObject.tag == "Player")
//        {
//            Animator1.enabled = true;
//            Animator1.Play(WhatAnimation);
//            Animator2.enabled = true;
//        }
//    }

}