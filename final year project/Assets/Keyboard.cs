using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Keyboard : MonoBehaviour
{
    public InputField[] InputBlock;
    public int current_inputfield = 0;
    public GameObject Board;

    public void InputString(string inputstring)
    {
        InputBlock[current_inputfield].text += inputstring;
    }

    public void Backspace()
    {
        if (InputBlock[current_inputfield].text.Length > 0)
        {
            InputBlock[current_inputfield].text = InputBlock[current_inputfield].text.Remove(InputBlock[current_inputfield].text.Length - 1);
        }
    }

    public void Next_btn()
    {
        current_inputfield += 1;
        if (current_inputfield > InputBlock.Length)
        {
            current_inputfield = InputBlock.Length;
        }
    }

    private void Update()
    {

        
        if (EventSystem.current.currentSelectedGameObject != null)
        {
            Debug.Log(EventSystem.current.currentSelectedGameObject.tag.ToString());
        }


       if (EventSystem.current.currentSelectedGameObject!=null && EventSystem.current.currentSelectedGameObject.tag.ToString()=="Input")
        {
            Board.SetActive(true);
        }
        else
        {
            Board.SetActive(false);
        }


        


    }
        
    



}
