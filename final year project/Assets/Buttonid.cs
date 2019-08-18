using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using TMPro;

public class Buttonid : MonoBehaviour
{
    
    public static int id=0;
    public static int Step=0;
    public GameObject ui;
    public GameObject Intro;
    public GameObject Enable;
    public GameObject Disable;

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
        Intro.SetActive(!Intro.active);
        if (ui.active == true){
            Enable.SetActive(true);
            Disable.SetActive(false);
         

        }
        else
        {
            Enable.SetActive(false);
            Disable.SetActive(true);
            
        }
    }


}