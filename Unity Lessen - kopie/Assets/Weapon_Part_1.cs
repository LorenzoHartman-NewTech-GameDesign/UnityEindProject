using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; 

public class Weapon_Part_1 : MonoBehaviour
{

    public GameObject player;
    public GameObject weaponHolder;
    public GameObject weaponOnAltar;
    public ParticleSystem mysticWeaponEffect;
    private Vector3 playerLocation;
    public CameraShake cameraShakeScript;
    public Transform altaar1;
    public Transform altaar2;
    public AudioSource playerAudio;
    public AudioClip epicMusic;
    public TextMeshProUGUI text; 


    private void OnTriggerStay(Collider other)
    {
        if (Input.GetButtonDown("Interact"))
        {
            //Removes the weapon from the Shrine. 
            weaponOnAltar.SetActive(false);
            //Activates the weapon you secretely had all along. 
            weaponHolder.SetActive(true);
            //Removes the particle effect that came of the shrine weapon. 
            Destroy(mysticWeaponEffect);
            //Teleports the player to an exact copy of the room somewhere else.
            //Done by using the two altaars as reference points. 
            playerLocation = altaar1.position - player.transform.position;
            player.transform.position = altaar2.position - playerLocation;
            //Turns on the camera shake Script for a dramatic effect. 
            cameraShakeScript.enabled = true;
            //Spices up the music.
            playerAudio.PlayOneShot(epicMusic);
            //Makes the text show up in the top right.
            text.enabled = true; 


        }
    }
}
