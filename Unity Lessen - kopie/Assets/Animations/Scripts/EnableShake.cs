using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableShake : MonoBehaviour
{


    public GameObject CameraShake;
    
   
    

    void ShakeCamera()
    {
        CameraShake.GetComponent<CameraShake>().enabled = true;
    }



}
