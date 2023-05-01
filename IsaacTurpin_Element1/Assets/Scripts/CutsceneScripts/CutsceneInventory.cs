using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CutsceneInventory : MonoBehaviour
{
    public UnityEvent<CutsceneInventory> OnSwitchStay;
    public UnityEvent<CutsceneInventory> OnSwitchTwo;
    Switch1 switch1;
    Switch2 switch2;
    public GameObject panel1;
    public GameObject panel2;
    public float speed = 2;

    private void Awake()
    {
        switch1= panel1.GetComponent<Switch1>();
        switch2 = panel2.GetComponent<Switch2>();
    }
    public void SwitchStay()
    {
        //Debug.Log(switchClass.switchNum);
        //if(switch1.switchNum == 1)
        //{
            if (panel1.transform.position.y != -0.1f)
            {
                panel1.transform.position += new Vector3(0, -0.1f, 0) * speed;

                if (panel1.transform.position.y <= -0.1f)
                {
                    speed = 0f;
                    //cutsceneInventory.SwitchStay();
                    //Debug.Log("Switch: " + switchNum);
                }
            }

            OnSwitchStay.Invoke(this);
       // }

    }

    public void SwitchOne()
    {

    }

    public void SwitchTwo()
    {
        OnSwitchTwo.Invoke(this);

        //Debug.Log("on switch");
    }
}
