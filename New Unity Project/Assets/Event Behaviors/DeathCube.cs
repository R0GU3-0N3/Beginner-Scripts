using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathCubeScript : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
    }
}