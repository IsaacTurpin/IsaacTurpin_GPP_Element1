using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamUp : MonoBehaviour
{
    public Camera thisCam;
    public Camera StaticCam;
    public float speed = 5f;
    public float speed2 = 50f;
    PlayerController playerController;

    private void Awake()
    {
        playerController = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(thisCam.enabled == true)
        {
            playerController.speed = 0;
            playerController.speed2 = 0;
            playerController.jumpHeight = 0;
            thisCam.transform.position += new Vector3(0, 1f, 0) * speed * Time.deltaTime;

            if(thisCam.transform.position.y >= 25)
            {
                speed = 0;
                thisCam.transform.position += new Vector3(0, 0, -1f) * speed2 * Time.deltaTime;

                if(thisCam.transform.position.z <= -200)
                {
                    speed2 = 0;
                    StaticCam.enabled = true;
                    thisCam.enabled = false;
                }
            }
        }
        
    }
}
