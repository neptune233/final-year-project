﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using TMPro;

public class Buttonid : MonoBehaviour
{
    
    public static int id=0;
    public static int Step;
    public GameObject ui;
    public TextMeshProUGUI HideUIbutton;

    // check which step button is pressed
    public void Stepid()
    {

        if (EventSystem.current.currentSelectedGameObject.name == "Step1")
        {
            Step = 1;
        }
        if (EventSystem.current.currentSelectedGameObject.name == "Step2")
        {
            Step = 2;
        }
        if (EventSystem.current.currentSelectedGameObject.name == "Step3")
        {
            Step = 3;
        }
        if (EventSystem.current.currentSelectedGameObject.name == "Step4")
        {
            Step = 4;
        }
    }

    // check which button is pressed
    public void Buttonname()
    {
        if (EventSystem.current.currentSelectedGameObject.name == "fixed angle Button")
        {
            id = 1;
        }
        if (EventSystem.current.currentSelectedGameObject.name == "euler angle Button")
        {
            id = 2;
        }
        if (EventSystem.current.currentSelectedGameObject.name == "directly transformation")
        {
            id = 3;
        }
        if (EventSystem.current.currentSelectedGameObject.name == "apply transformation matrix")
        {
            id = 4;
        }



    }

    public void HideUI()
    {
        ui.SetActive(!ui.active);
        if (ui.active == true){
            HideUIbutton.text = "Disable UI";
        }
        else
        {
            HideUIbutton.text = "Enable UI"; 
        }
    }
}