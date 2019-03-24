using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonNew : MonoBehaviour
{

    public Animator Animator1;
    public Animator Animator2;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Animator1.enabled = true;
            Animator2.enabled = true;
        }
    }

}
