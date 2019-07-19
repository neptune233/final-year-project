using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quiz : MonoBehaviour
{
    public GameObject ChoiceA;
    public GameObject ChoiceB;
    public GameObject ChoiceC;
    public GameObject ChoiceD;
    public GameObject LeftArrow;
    public GameObject RightArrow;
    public GameObject True;
    public GameObject False;

    // function when press the leftarrow
    public void Left()
    {
        if (ChoiceA.activeSelf == true)
        {
            ChoiceA.SetActive(false);
            ChoiceD.SetActive(true);
            
            Debug.Log('D');
            
        }
        else if (ChoiceB.activeSelf == true)
        {
            ChoiceB.SetActive(false);
            ChoiceA.SetActive(true);
            Debug.Log('A');
        }
        else if (ChoiceC.activeSelf == true)
        {
            ChoiceC.SetActive(false);
            ChoiceB.SetActive(true);
            Debug.Log('B');

        }
        else if (ChoiceD.activeSelf == true)
        {
            ChoiceD.SetActive(false);
            ChoiceC.SetActive(true);
            Debug.Log('C');

        }
    }

    // function when press the rightarrow
 
    public void Right()
    {
        if (ChoiceA.activeSelf == true)
        {
            ChoiceA.SetActive(false);
            ChoiceB.SetActive(true);
            Debug.Log('B');
        }
        else if (ChoiceB.activeSelf == true)
        {
            ChoiceB.SetActive(false);
            ChoiceC.SetActive(true);
            Debug.Log('C');
        }
        else if (ChoiceC.activeSelf == true)
        {
            ChoiceC.SetActive(false);
            ChoiceD.SetActive(true);
            Debug.Log('D');
        }
        else if (ChoiceD.activeSelf == true)
        {
            ChoiceD.SetActive(false);
            ChoiceA.SetActive(true);
            Debug.Log('A');
        }
    }

    public void Q_1_T()
    {
        True.SetActive(true);
        False.SetActive(false);
    }

    public void Q_1_F()
    {
        True.SetActive(false);
        False.SetActive(true);
    }
}
