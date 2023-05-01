using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStayOnPlatform : MonoBehaviour
{
    //public GameObject PlayerCharacter;
    public GameObject platform;
    private void Awake()
    {
        //GameObject PlayerCharacter = GameObject.FindGameObjectWithTag("Player");
    }
    private void OnTriggerEnter(Collider other)
    {
        //Collider playerCollider = PlayerCharacter.GetComponent<Collider>();
        if(platform != null)
        {
            other.transform.SetParent(transform);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        //Collider playerCollider = PlayerCharacter.GetComponent<Collider>();
        if (platform != null)
        {
            other.transform.SetParent(null);
        }
    }
}
