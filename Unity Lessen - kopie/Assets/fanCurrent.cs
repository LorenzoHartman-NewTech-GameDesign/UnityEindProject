using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fanCurrent : MonoBehaviour
{
    public Transform player;
    public Animator animator;
    public enum AirCurrentStrenght { slowed, normal, stopped,sped_up};
    public AirCurrentStrenght _AirCurrentStrenght; 




    void OnTriggerStay(Collider other)
    {
        player.transform.position = player.transform.position + new Vector3(0, 0.5f, 0); 
    }

    // Update is called once per frame
    void Update()
    {
        if (animator.speed == 1f)
        {



        }











}
}
