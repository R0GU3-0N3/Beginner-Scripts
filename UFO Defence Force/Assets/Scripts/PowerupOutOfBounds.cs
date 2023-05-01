using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerupOutOfBounds : MonoBehaviour
{
    public float topBounds = 30.0f;

    public float bottomBounds = -10.0f;


    void Update()
    {
        if(transform.position.z < bottomBounds)
        {
            Destroy(gameObject);
        }
    }
}
