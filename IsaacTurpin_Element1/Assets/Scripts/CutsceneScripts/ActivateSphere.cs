using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateSphere : MonoBehaviour
{
    public GameObject triggerSphere;

    // Start is called before the first frame update
    void Start()
    {
        triggerSphere.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
