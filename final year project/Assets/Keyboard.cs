using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Keyboard : MonoBehaviour
{
    public InputField InputBlock;


    public void InputString(string inputstring)
    {
        InputBlock.text += inputstring;
    }

    public void Backspace()
    {
        InputBlock.text.Remove(InputBlock.text.Length - 1);
    }
}
