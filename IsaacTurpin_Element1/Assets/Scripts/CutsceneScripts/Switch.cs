using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour
{
    //public GameObject panel;
    //public float speed = 2f;
    public GameObject panel1;
    public int switchNum = 1;
    CutsceneInventory cutsceneInventory;

    //public int switchNum;

    // [SerializeField] public SwitchNum switchNum;
    //  public enum SwitchNum 
    //  {
    //      One,
    //      Two,
    //      Three
    //  }

    private void Awake()
    {
        cutsceneInventory = GameObject.FindGameObjectWithTag("Player").GetComponent<CutsceneInventory>();
    }
    private void OnTriggerStay(Collider other)
    {
        //CutsceneInventory cutsceneInventory = other.GetComponent<CutsceneInventory>();
        //Switch1 switch1 = other.GetComponent<Switch1>();
        //Switch2 switch2 = other.GetComponent<Switch2>();

        if(panel1 != null)
        {
            cutsceneInventory.SwitchStay();
        }
    }


    //  public SwitchNum GetSwitchNum()
    //   {
    //       return switchNum;
    //   }
}
