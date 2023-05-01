using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiddleTilt : MonoBehaviour
{
    public GameObject front;
    public GameObject middle;
    public GameObject back;
    public GameObject platform;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay(Collider other)
    {
        //Collider playerCollider = PlayerCharacter.GetComponent<Collider>();
        if (middle != null)
        {

        }
    }
}
