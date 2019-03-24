using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour

      


{

    public GameObject AnimatedObject;
    Animator otherAnimator;
    public string Animation1;
    public string Animation2; 


    void PlayAnimation1()
    {
        otherAnimator = AnimatedObject.GetComponent<Animator>();
        otherAnimator.gameObject.GetComponent<Animator>().enabled = true;
        otherAnimator.Play(Animation1);
    }


    void PlayAnimation2()
    {
        otherAnimator = AnimatedObject.GetComponent<Animator>();
        otherAnimator.gameObject.GetComponent<Animator>().enabled = true;
        otherAnimator.Play(Animation2);
    }

    //// Start is called before the first frame update
    //void Start()
    //{






    //}

    //// Update is called once per frame
    //void Update()
    //{

    //}
}
