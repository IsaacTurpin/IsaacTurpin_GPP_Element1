using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCam : MonoBehaviour
{
    public Camera thisCam;
    public Camera nextCam;
    public float timer = 5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(thisCam.enabled == true)
        {
            timer -= Time.deltaTime;

            if(timer <= 0)
            {
                thisCam.enabled = false;
                nextCam.enabled = true;
            }
        }
    }
}
