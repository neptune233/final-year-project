
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HideVirtualKeyboard : InputField
{

    // Use this for initialization
    protected override void Start()
    {
        keyboardType = (TouchScreenKeyboardType)(-1);
        base.Start();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
