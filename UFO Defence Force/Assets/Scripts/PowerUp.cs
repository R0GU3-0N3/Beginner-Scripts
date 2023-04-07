using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    public PowerUpEffect powerupEffect;
    void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("Player"))
        {
            Debug.Log("Power Up Collected!");
            Destroy(gameObject);
            powerupEffect.Apply(other.gameObject);
        }

    }
}
