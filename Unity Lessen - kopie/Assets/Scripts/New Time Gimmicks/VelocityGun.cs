using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; 

public class VelocityGun : MonoBehaviour
{


    public Camera fpsCam;
    public float range = 100f;
    public float fireRate = 15f;
    private float nextTimeToFire = 0f;
    public Animation anim;
    public enum gunType {Slowdown, Increase, Stop};
    public gunType TypeofGun;
    public float waitTime;
    IEnumerator coroutine;
    public TextMeshProUGUI TimeTypeUI; 


    Animator otherAnimator;



    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1") && Time.time >= nextTimeToFire)
        {
            nextTimeToFire = Time.time + 1f / fireRate;

            Shoot();
        }


        if (Input.GetButton("Ability1"))
        {
            TypeofGun = gunType.Slowdown;
            TimeTypeUI.text = TypeofGun.ToString(); 

        }

        if (Input.GetButton("Ability2"))
        {
            TypeofGun = gunType.Stop;
            TimeTypeUI.text = TypeofGun.ToString();
        }
        if (Input.GetButton("Ability3"))
        {
            TypeofGun = gunType.Increase;
            TimeTypeUI.text = TypeofGun.ToString();
        }



    }

void Shoot()
    {
        RaycastHit hit;
        if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range) )
        {
            
            Transform otherObject = hit.transform;
            while (otherObject.tag != "influenceable" )
            {
                Debug.Log("Gottem" + otherObject.name);
                if (otherObject.parent == null) { return; }
                otherObject = otherObject.parent;
            }

            if (otherObject.GetComponent<Animator>() == null) return;

            //(Debug Message to check if it actually hit.)
            

            //Sets otherObject to the hit gameobject. 
            
            //Sets OtherAnimator to the Animator component we have just received from the raycast hit. 
            otherAnimator = otherObject.GetComponent<Animator>();
            //Changes the animation speed to a lower value to create the illusion of slowing down. 

            switch(TypeofGun)
            {
                case gunType.Slowdown:
                    otherAnimator.speed = 0.1f;
                    Invoke("ResetSpeed", waitTime);
                    break;

                case gunType.Increase:
                    otherAnimator.speed = 2f;
                    Invoke("ResetSpeed", waitTime);
                    break;

                case gunType.Stop:
                    otherAnimator.speed = 0f;
                    Invoke("ResetSpeed", waitTime);
                    break; 
            }

           



            ////Resets animator speed
            //StopCoroutine("ResetSpeed"); 

            //coroutine = ResetSpeed(otherAnimator);
            
            //StartCoroutine(coroutine); 

    
        }


    }

    void ResetSpeed()
    {
        otherAnimator.speed = 1f;
    }


    //private IEnumerator ResetSpeed(Animator am)
    //{
    //    yield return new WaitForSeconds(waitTime);
    //    am.speed = 1f;
}
    





