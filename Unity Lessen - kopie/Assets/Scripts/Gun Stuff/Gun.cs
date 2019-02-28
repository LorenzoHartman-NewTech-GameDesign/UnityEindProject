using UnityEngine;

public class Gun : MonoBehaviour{

    public float damage = 10f;
    public float range = 100f;
    public Camera fpsCam;
    public ParticleSystem MuzzleFlash;
    public ParticleSystem cartridge; 
    public GameObject impactEffect;
    public GameObject bulletHole; 
    public float impactForce =30f;
    public float fireRate = 15f;
    private float nextTimeToFire = 0f;
    enum GunType {normal, time}; 


 



    void Update() { 
    //Allows us to shoot if we can. 
        if (Input.GetButton("Fire1") && Time.time >= nextTimeToFire)
        {
            nextTimeToFire = Time.time + 1f / fireRate;
            MuzzleFlash.Play();
            cartridge.Play(); 
            Shoot();
        }


    }


    //Shoots the Normal Gun.
    void Shoot()
    {
        
        RaycastHit hit;
        //Shoots out a raycast, if it hits a target inside our set range it will run the code below. 
        if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range))
        { 
            Debug.Log(hit.transform.name);
            //Checks if there is a target script attached to the object. 
            //This allows us to set HP and choose what objects can be harmed and set a destroyed version if needed. 
            Target target = hit.transform.GetComponent<Target>();
            if (target != null)
            {
                target.TakeDamage(damage); 
            }
            //If the target is a rigid body it will also create some impactforce for a more realistic effect. 
            if (hit.rigidbody != null) {
                hit.rigidbody.AddForce(hit.normal * impactForce *-1); 
            }
            //This creates the bullet holes and dust effect on a target. It creates it outwards on the object from our look rotation. 
            GameObject impactGO = Instantiate(impactEffect, hit.point, Quaternion.LookRotation(hit.normal));
            GameObject bulletGO = Instantiate(bulletHole, hit.point, Quaternion.LookRotation(hit.normal));
            bulletGO.transform.parent = hit.transform;
            //Cleans up our effects after a delay so we dont have a ton of game objects. 
            Destroy(impactGO, 2f);
            Destroy(bulletGO, 2f); 

        
    }
    }


}



