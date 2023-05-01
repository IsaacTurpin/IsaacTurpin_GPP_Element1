using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetUpCams : MonoBehaviour
{
    public Camera MainCam;
    public Camera DoorCam;
    public Camera MoveUpCam;
    public Camera StaticSetPCam;
    public Camera StaticShakeCam;
    public Camera PlatformCam;
    public Camera PlatformRewardCam;
    // Start is called before the first frame update
    void Start()
    {
        MainCam.enabled = true;
        DoorCam.enabled = false;
        MoveUpCam.enabled = false;
        StaticSetPCam.enabled = false;
        StaticShakeCam.enabled = false;
        PlatformCam.enabled = false;
        PlatformRewardCam.enabled = false;

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
