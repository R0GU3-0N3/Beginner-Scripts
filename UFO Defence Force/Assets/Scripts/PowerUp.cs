using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    public int powerupnumber;
    
    public void Start()
    {
        powerupnumber = 0;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Power Up Collected!");
            Destroy(gameObject); 
            powerupnumber += 1;
        }

    }
}
