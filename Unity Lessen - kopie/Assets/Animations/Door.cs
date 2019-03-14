using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour

      


{

    public GameObject DoorObject;
    Animator otherAnimator; 


    void OpenDoor()
    {
        otherAnimator = DoorObject.GetComponent<Animator>();
        otherAnimator.gameObject.GetComponent<Animator>().enabled = true;
        otherAnimator.Play("OpenDoor");
    }


    void CloseDoor()
    {
        otherAnimator = DoorObject.GetComponent<Animator>();
        otherAnimator.gameObject.GetComponent<Animator>().enabled = true;
        otherAnimator.Play("CloseDoor");
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
