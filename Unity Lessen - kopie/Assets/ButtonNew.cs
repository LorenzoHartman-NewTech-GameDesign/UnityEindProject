using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonNew : MonoBehaviour
{

    public Animator Animator; 

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Animator.enabled = true;
        }
    }

}
