using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonNew : MonoBehaviour
{

    public Animator Animator1;
    public Animator Animator2;
    public string AnimationName1;
    public string AnimationName2; 

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Animator1.enabled = true;
            //Animator1.Play(AnimationName2);
            Animator1.Play(AnimationName1, -1, 0f);
            Animator2.enabled = true;
        }
    }

}
