using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cutscene : MonoBehaviour
{
    public Camera triggeredCam;
    public Camera liveCam;

    public int doorNum;
    public GameObject door1;
    public GameObject door2;
    public float speed = 0.5f;


    Switch1 switch1;
    Switch2 switch2;
    public GameObject panel1;
    public GameObject panel2;

    PlayerController playerController;

    public float delay = 0f;

    private void Awake()
    {
        liveCam = Camera.allCameras[0];
        switch1 = panel1.GetComponent<Switch1>();
        switch2 = panel2.GetComponent<Switch2>();
        playerController = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
    }
    // Start is called before the first frame update
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(door.transform.position.y);
    }

    public void ChangeCams1()
    {
        //if (switch1.switchNum == doorNum)
       // {
            delay += Time.deltaTime;

            if (delay >= 0.5)
            {
                triggeredCam.enabled = true;
                liveCam.enabled = false;
                playerController.speed = 0;
                playerController.speed2 = 0;
                playerController.jumpHeight = 0;
                AnimateDoor1();
            }
       // }

    }

    public void ChangeCams2()
    {
        //if (switch1.switchNum == doorNum)
        // {
        delay += Time.deltaTime;

        if (delay >= 0.5)
        {
            triggeredCam.enabled = true;
            liveCam.enabled = false;
            playerController.speed = 0;
            playerController.speed2 = 0;
            playerController.jumpHeight = 0;
            AnimateDoor2();
        }
        // }

    }

    public void AnimateDoor1()
    {
        if (door1.transform.position.y != -4.9f)
        {
            door1.transform.position += new Vector3(0, -1f, 0) * speed * Time.deltaTime;

            if (door1.transform.position.y <= -4.9f)
            {
                speed = 0f;
                // Debug.Log("door done");

                triggeredCam.enabled = false;
                liveCam.enabled = true;
                playerController.speed = 2;
                playerController.speed2 = 4;
                playerController.jumpHeight = 3;

            }

        }
    }

    public void AnimateDoor2()
    {
        if (door2.transform.position.y != -4.9f)
        {
            door2.transform.position += new Vector3(0, -1f, 0) * speed * Time.deltaTime;

            if (door2.transform.position.y <= -4.9f)
            {
                speed = 0f;
                // Debug.Log("door done");

                triggeredCam.enabled = false;
                liveCam.enabled = true;
                playerController.speed = 2;
                playerController.speed2 = 4;
                playerController.jumpHeight = 3;

            }

        }
    }
}