
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour 
{

    // I brought this event script over from my simple fps prototype, which I hope to post on my github someday!

    public static Action shootInput;
    public static Action reloadInput;

    [SerializeField] private KeyCode reloadKey = KeyCode.R;

    private void Update()
    {
        if (Input.GetMouseButton(0))
            shootInput?.Invoke();

        if (Input.GetKeyDown(reloadKey))
            reloadInput?.Invoke();
    }
}