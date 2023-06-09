using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShake : MonoBehaviour
{
    public Transform cameraTransform;
    private Vector3 camPosition;
    public float shakeStrength;
    // Start is called before the first frame update
    void Start()
    {
        camPosition = cameraTransform.position;
    }

    // Update is called once per frame
    void Update()
    {
        shakeStrength = 0.3f;
        CameraMove();
    }
    void CameraMove()
    {
        cameraTransform.position = camPosition + Random.insideUnitSphere * shakeStrength;
    }
}
