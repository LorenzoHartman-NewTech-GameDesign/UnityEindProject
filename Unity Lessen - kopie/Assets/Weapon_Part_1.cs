using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
    



    private void OnTriggerStay(Collider other)
    {

        

        if (Input.GetButtonDown("Interact"))
        {

            weaponOnAltar.SetActive(false); 
            weaponHolder.SetActive(true);
            Destroy(mysticWeaponEffect);
            playerLocation = altaar1.position - player.transform.position;
            player.transform.position = altaar2.position - playerLocation;
            cameraShakeScript.enabled = true; 





        }
    }




}
