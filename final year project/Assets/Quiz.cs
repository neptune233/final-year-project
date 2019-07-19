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
    public GameObject Q0_A;
    public GameObject Q0_B;
    public GameObject Q0_C;
    public GameObject Q0_D;
    public GameObject Ans0;
    public GameObject Q0;

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

    // Question 0
    public void Q_0_A()
    {
        Q0_A.SetActive(true);
        Q0_B.SetActive(false);
        Q0_C.SetActive(false);
        Q0_D.SetActive(false);
    }

    public void Q_0_B()
    {
        Q0_A.SetActive(false);
        Q0_B.SetActive(true);
        Q0_C.SetActive(false);
        Q0_D.SetActive(false);
        Ans0.SetActive(true);
        Q0_B.SetActive(false);

    }

    public void Q_0_C()
    {
        Q0_A.SetActive(false);
        Q0_B.SetActive(false);
        Q0_C.SetActive(true);
        Q0_D.SetActive(false);
    }

    public void Q_0_D()
    {
        Q0_A.SetActive(false);
        Q0_B.SetActive(false);
        Q0_C.SetActive(false);
        Q0_D.SetActive(true);
    }

}
