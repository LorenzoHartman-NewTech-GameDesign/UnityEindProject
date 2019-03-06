using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VelocityGun : MonoBehaviour
{


    public Camera fpsCam;
    public float range = 100f;
    public float fireRate = 15f;
    private float nextTimeToFire = 0f;
    public Animation anim;

    public GameObject otherObject;
    Animator otherAnimator;



    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Fire1") && Time.time >= nextTimeToFire)
        {
            nextTimeToFire = Time.time + 1f / fireRate;

            Shoot();
        }



    }



    void Shoot()
    {
        RaycastHit hit;
        if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range) && hit.transform.tag == "influenceable")
        {
            //(Debug Message to check if it actually hit.)
            Debug.Log("Gottem");

            //Sets otherObject to the hit gameobject. 
            otherObject = hit.transform.gameObject;
            //Sets OtherAnimator to the Animator component we have just received from the raycast hit. 
            otherAnimator = otherObject.GetComponent<Animator>();
            //Changes the animation speed to a lower value to create the illusion of slowing down. 
            otherAnimator.speed = 0.1f; 
        }
    }

    


    




}
