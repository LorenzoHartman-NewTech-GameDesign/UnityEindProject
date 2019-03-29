using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; 

public class destroyText : MonoBehaviour
{



    public GameObject text; 

    // Start is called before the first frame update

    private void OnTriggerEnter(Collider other)
    {
        Destroy(text); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
