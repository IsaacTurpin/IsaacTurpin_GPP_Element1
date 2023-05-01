using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch2 : MonoBehaviour
{
    public int switchNum = 2;
    public GameObject panel2;
    public float speed = 2f;
    CutsceneInventory cutsceneInventory;

    private void Awake()
    {
        cutsceneInventory = GameObject.FindGameObjectWithTag("Player").GetComponent<CutsceneInventory>();
    }

    private void OnTriggerStay(Collider other)
    {
        if (panel2 != null)
        {
            Debug.Log("2");
            if (panel2.transform.position.y != -0.1f)
            {
                panel2.transform.position += new Vector3(0, -0.1f, 0) * speed;

                if (panel2.transform.position.y <= -0.1f)
                {
                    speed = 0f;
                }
            }
            cutsceneInventory.SwitchTwo();
        }
    }
}