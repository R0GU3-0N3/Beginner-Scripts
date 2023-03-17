using UnityEngine;

public class MaterialChange : MonoBehaviour
{
    public Material color1;
    public Material color2;
 
    void OnTriggerEnter(Collider other)
    {
        print(other.name);
        if (other.name == "Player")
        {
            GetComponent<Renderer>().material.color = Color.blue;
            Debug.Log("Player Collided with CUBE");
        }
        else {
            GetComponent<Renderer>().material.color = Color.green;
        }
    }
    void OnTriggerExit(Collider other)
    {
        if(other)
        GetComponent<Renderer>().material.color = Color.blue;
        Debug.Log("Player Exit");      
    }
}