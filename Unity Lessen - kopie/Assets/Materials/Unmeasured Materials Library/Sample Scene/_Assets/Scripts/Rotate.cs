using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public Vector3 amount = Vector3.zero;

    public float sineFreq = 0;

    void Update()
    {
        float t = Time.deltaTime;
        if (sineFreq > 0) {
            t = Mathf.Sin(Time.time * sineFreq);
            transform.localEulerAngles = amount * t;
        } else {
            transform.Rotate(amount * t, Space.Self);
        }
    }
}
