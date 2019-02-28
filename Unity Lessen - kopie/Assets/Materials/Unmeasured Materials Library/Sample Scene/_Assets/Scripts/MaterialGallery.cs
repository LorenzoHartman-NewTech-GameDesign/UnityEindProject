using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MaterialGallery : MonoBehaviour
{

    public Renderer[] renderers;
    public Material[] materials;
    public Camera[] cameras;
    public Text text;
    public Text number;
    public float interval = 3;
    public float caminterval = 3;
    public int startIndex = 0;
    public bool useFrames = false;

    int i = 0;
    float t = 0;
    int cami;
    float camt = 0;
    void Start()
    {
        i = startIndex;
        Switch();
        SwitchCam();
    }

    void Update()
    {
        if (useFrames) {
            i =  (int)Mathf.Repeat(i + 1, materials.Length);
            Switch();
        } else {
            t += Time.deltaTime;
            if (t > interval || Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.LeftArrow)) {
                t = 0;
                camt = 0;
                if (Input.GetKeyDown(KeyCode.RightArrow))
                    i =  (int)Mathf.Repeat(i + 1, materials.Length);
                else if (Input.GetKeyDown(KeyCode.LeftArrow))
                    i =  (int)Mathf.Repeat(i - 1, materials.Length);
                else
                    i =  (int)Mathf.Repeat(i + 1, materials.Length);
                Switch();
            }
        }

        camt += Time.deltaTime;
        if (camt > caminterval || Input.GetKeyDown(KeyCode.C)) {
            camt = 0;  
            cami =  (int)Mathf.Repeat(cami + 1, cameras.Length);
            SwitchCam();
            t = 0;
        }
    }

    void Switch() {
        foreach (var r in renderers) {
            r.material = materials[i];

        }
        text.text = materials[i].name;
        number.text = "#" + i;
    }

    void SwitchCam() {
        for(int i = 0; i < cameras.Length; i++) {
            cameras[i].enabled = i == cami;
        }
    }
}
