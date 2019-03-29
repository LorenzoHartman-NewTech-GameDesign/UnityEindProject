using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson; 

public class fanCurrent : MonoBehaviour
{
    public Rigidbody player;
    
    public float force; 
    public Animator animator;
    public enum AirCurrentStrenght { slowed, normal, stopped,sped_up};
    public AirCurrentStrenght _AirCurrentStrenght;

    //public Camera Camera; 


    

    void OnTriggerStay(Collider other)
    {
        player.GetComponent<FirstPersonController>().m_MouseLook.XSensitivity = 0;
        player.GetComponent<FirstPersonController>().m_MouseLook.YSensitivity = 0;


        player.AddForce(transform.up * 1, ForceMode.VelocityChange);
        player.isKinematic = false;
        player.detectCollisions = true;
        //Camera.enabled = false; 
    }

    void OnTriggerExit(Collider other)
    {
        player.GetComponent<FirstPersonController>().m_MouseLook.XSensitivity = 4;
        player.GetComponent<FirstPersonController>().m_MouseLook.YSensitivity = 4;

        player.isKinematic = true;
        player.detectCollisions = true;
    }

    // Update is called once per frame
  
}
