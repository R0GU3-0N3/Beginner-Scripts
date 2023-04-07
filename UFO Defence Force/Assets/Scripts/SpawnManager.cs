using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] ufoPrefabs;

    public int ufoIndex;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.S))
        {
            Instantiate(ufoPrefabs[ufoIndex],new Vector3(0, 0, 15), ufoPrefabs[ufoIndex].transform.rotation);
        }
    }
}
