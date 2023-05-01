using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformDestruct : MonoBehaviour
{
    public GameObject platform;
    public float destroySpeed;
   // [SerializeField] private Material myMaterial;
    [SerializeField] private Renderer myModel;
    // public Material baseMaterial;
    public Material redMaterial;
    private float alphaValue;

    //public MeshRenderer meshRenderer;

    // Start is called before the first frame update
    void Start()
    {
        alphaValue = myModel.material.color.a;
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(alphaValue);
    }

    private void OnTriggerStay(Collider other)
    {

        if(platform != null)
        {
            myModel.material = redMaterial;

            // Color color = redMaterial.color;
            // color.a = 255;
            Fade();
            //Color color = myModel.material.color;
            //color.a = 255;
            //myModel.material.color = color;
        }
    }

    public void Fade()
    {
        Color color = redMaterial.color;
        color.a = alphaValue;
        redMaterial.color = color;
        alphaValue -= destroySpeed * Time.deltaTime;
        if(alphaValue <= 0)
        {
            destroySpeed = 0;
            platform.SetActive(false);
        }
    }

    private void OnDestroy()
    {
        Destroy(myModel.material);
    }
}
