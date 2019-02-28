/*using UnityEngine;

public class TimeManager : MonoBehaviour
{
    
    public float slowdownFactor = 0.05f;
    public float slowdownLength = 2f;

    void Update()
    {
        Time.timeScale += (1f / slowdownLength) * Time.unscaledDeltaTime;
        Time.timeScale = Mathf.Clamp(Time.timeScale, 0f, 1f);
    }

   
public void Activate()
    {
        if (Input.GetButton("Fire1"))
        {
            Time.timeScale = 0; 
        }
    }

/*
    public void DoSlowmotion()
    {
        
        Time.timeScale = slowdownFactor;
        Time.fixedDeltaTime = Time.timeScale * .02f;
    }
    
}*/



using UnityEngine;

public class TimeManager : MonoBehaviour
{
    // Toggles the time scale between 1 and 0
    // whenever the user hits the Fire1 button.

    void Update()
    {
        if (Input.GetButtonDown("Fire2")) 
        {
            if (Time.timeScale == 1.0f)
                Time.timeScale = 0f;
            else
                Time.timeScale = 1.0f;
            // Adjust fixed delta time according to timescale
            // The fixed delta time will now be 0.02 frames per real-time second
            Time.fixedDeltaTime = 0.02f * Time.timeScale;
        }
    }
}
