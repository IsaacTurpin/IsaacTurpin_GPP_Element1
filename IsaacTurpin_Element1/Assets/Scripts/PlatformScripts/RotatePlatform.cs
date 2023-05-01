using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatePlatform : MonoBehaviour
{
    public GameObject platform;
    public bool canRotateFront;
    public bool canRotateBack;
    public float rotateAmountX;
    public float maxRotateX;
    public float minRotateX;
    // Start is called before the first frame update
    void Start()
    {
        canRotateFront = true;
        canRotateBack = true;
    }

    // Update is called once per frame
    void Update()
    {
        //OnFront();
    }

    public void OnFront()
    {
        canRotateBack = true;
        if(canRotateFront)
        {
            platform.transform.Rotate(new Vector3(rotateAmountX, 0f, 0f) * Time.deltaTime);
            if (platform.transform.rotation.x >= maxRotateX)
            {
                canRotateFront = false;
            }
        }

    }

    public void OnBack()
    {
        canRotateFront = true;
        if(canRotateBack)
        {
            platform.transform.Rotate(- new Vector3(rotateAmountX, 0f, 0f) * Time.deltaTime);
            if (platform.transform.rotation.x <= minRotateX)
            {
                canRotateBack = false;
            }
        }

    }
}
