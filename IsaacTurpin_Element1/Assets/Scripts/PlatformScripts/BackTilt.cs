using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackTilt : MonoBehaviour
{
    public GameObject front;
    public GameObject middle;
    public GameObject back;
    public GameObject platform;
    RotatePlatform rotatePlatform;
    // Start is called before the first frame update
    void Start()
    {
        rotatePlatform = platform.GetComponent<RotatePlatform>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay(Collider other)
    {
        //Collider playerCollider = PlayerCharacter.GetComponent<Collider>();
        if (back != null)
        {
            rotatePlatform.OnBack();
        }
    }
}
