using UnityEngine;

public class Target : MonoBehaviour
{

    public GameObject destroyedVersion;
    public float health = 50f; 

    public void TakeDamage (float amount)
    {
        
        health -= amount;
        if (health <= 0f)
        {
            Die();

        }
    }

    void Die ()
    {
        //Creates the destroyed version of the object at the same location as the original. 
        Instantiate(destroyedVersion, transform.position, transform.rotation);
        Destroy(gameObject);
    }

}