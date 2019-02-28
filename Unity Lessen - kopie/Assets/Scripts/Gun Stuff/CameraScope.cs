using UnityEngine;

public class CameraScope : MonoBehaviour
{
    public float minFov = 60f;
    public float maxFov = 90f;
    private float fov = 60f; 

    void Update()
    {
        


        if (Input.GetButton("Fire2"))
        {
            fov = minFov;
        }
        else
        {
            fov = maxFov;
        }
        Camera.main.fieldOfView = fov;
    } }