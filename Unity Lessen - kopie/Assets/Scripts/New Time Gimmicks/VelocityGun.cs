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
    public enum gunType { Slowdown, Increase, Stop };
    public gunType TypeofGun;
    public float waitTime;
    IEnumerator coroutine;
    public TextMeshProUGUI TimeTypeUI;
    public Shader Normal;
    public Shader Influenced;
    public Shader ObjectShader;
    //Here we store the last hit Animators. And the time passed since we activated it. 
    Animator[] animatorList = new Animator[10];
    float[] timeList = new float[10]; 




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
        
        for (int i = 0; i < timeList.Length; i++) {
            
            
            if (timeList[i] > 0 && Time.time  > timeList[i] + waitTime)
            {
                animatorList[i].speed = 1;
                timeList[i] = 0f;
                animatorList[i] = null;
            }
        }
    }

    void Shoot()
    {
        RaycastHit hit;
        if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range))
        {

            Transform otherObject = hit.transform;
            while (otherObject.tag != "influenceable")
            {
                Debug.Log("Gottem", otherObject);
                if (otherObject.parent == null) { return; }
                otherObject = otherObject.parent;

            }

            if (otherObject.GetComponent<Animator>() == null) return;






            //Sets OtherAnimator to the Animator component we have just received from the raycast hit. 
            otherAnimator = otherObject.GetComponent<Animator>();

            ObjectShader = otherObject.GetComponent<Shader>();


            switch (TypeofGun)
            {
                case gunType.Slowdown:
                    otherAnimator.speed = 0.1f;

                    ObjectShader = Influenced;
                    //Invoke("ResetSpeed", waitTime);
                    break;

                case gunType.Increase:
                    otherAnimator.speed = 2f;
                    ObjectShader = Influenced;
                    //Invoke("ResetSpeed", waitTime);
                    break;

                case gunType.Stop:
                    otherAnimator.speed = 0f;
                    ObjectShader = Influenced;
                    //Invoke("ResetSpeed", waitTime);
                    break;
            }


            bool alreadyInList = false;

            for (int i = 0; i < animatorList.Length; i++)
            {
                if (animatorList[i] == otherAnimator)
                {
                    alreadyInList = true;
                    break;
                }
            }

            if (!alreadyInList)
            {
                for (int i = 0; i < timeList.Length; i++)
                {

                    if (timeList[i] == 0f)
                    {
                        animatorList[i] = otherAnimator;
                        timeList[i] = Time.time;
                        break;
                    }
                }
            }
            


        }


    }





}

