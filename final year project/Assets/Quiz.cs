using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;



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
    public GameObject Q1;
    public Matrix4x4 M1;
    public Matrix4x4 M2;
    public Matrix4x4 M3;
    public static Matrix4x4 Ans;
    public InputField[] Input;
    public GameObject Correct;
    public GameObject Wrong;
 
    
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



    ///////////////////
    public void Question1()
    {
        System.Random ran = new System.Random();
        string[] angle= { "30", "45", "60" };
        string[] xyz = new string[3];
        for(int i=0;i<3;i++)
        {
            xyz[i]= angle[ran.Next(0, 3)];
        }
        
        int b = ran.Next(0, 2);

        
        if (b <10)
        {
            Q1.GetComponent<TMPro.TextMeshProUGUI>().text = "Frame{B} is initally coincident with world coordinate system. Frame{B} is rotated about x axis itself by " + xyz[0] + " degree ,then rotated about y axis itself by " + xyz[1] + " degree,then about z aixs itself by " + xyz[2]+" degree. Finally,the origin of {B} is translated to [x y z]=[3 4 5] which is related to world. Try to caculate the transformation matrix which maps the point from frame{B} to world frame";
        }

        if (b < 9)
        {
            Q1.GetComponent<TMPro.TextMeshProUGUI>().text = "Frame{B} is initally coincident with world coordinate system. Frame{B} is rotated about x axis of world by " + xyz[0] + " degree ,then rotated about y axis of world by " + xyz[1] + " degree,then about z aixs of world by " + xyz[2] + " degree. Finally,the origin of {B} is translated to [x y z]=[3 4 5] which is related to the frame{B}. Try to caculate the transformation matrix which maps the point from frame{B} to world frame";
        }


        float angle1;
        float angle2;
        float angle3;
        angle1 = float.Parse(xyz[0])/180*Mathf.PI;
        Debug.Log(angle1);
        angle2 = float.Parse(xyz[1]) / 180 * Mathf.PI;
        Debug.Log(angle2);
        angle3 = float.Parse(xyz[2]) / 180 * Mathf.PI;
        Debug.Log(angle3);
        
        
        M1.m00 = 1;
        M1.m11 = Mathf.Cos(angle1);
        M1.m12 = -Mathf.Sin(angle1);
        M1.m21 = Mathf.Sin(angle1);
        M1.m22 = Mathf.Cos(angle1);
        M1.m33 = 1;

        
        M2.m00 = Mathf.Cos(angle2);
        M2.m02 = Mathf.Sin(angle2);
        M2.m11 = 1;
        M2.m20 = -Mathf.Sin(angle2);
        M2.m22 = Mathf.Cos(angle2);
        M2.m33 = 1;

        M3.m00 = Mathf.Cos(angle3);
        M3.m11 = Mathf.Cos(angle3);
        M3.m01 = -Mathf.Sin(angle3);
        M3.m10 = Mathf.Sin(angle3);
        M3.m22 = 1;
        M3.m33 = 1;

        Ans = M1 * M2 * M3;
        Ans.m03 = 3;
        Ans.m13 = 4;
        Ans.m23 = 5;

        Debug.Log(Ans);
        

    }

    public void CheckAns()
    {
        float temp;
        bool error = true;
        for (int i = 0; i < 16; i++)
        {
            if (float.TryParse(Input[i].text, out temp) == false)
            {
                error = false;
                break;
            }
        }
        if (error == true)
        {
            if (Mathf.Abs(float.Parse(Input[0].text) - Ans.m00) < 0.01f && Mathf.Abs(float.Parse(Input[1].text) - Ans.m01) < 0.01f && Mathf.Abs(float.Parse(Input[2].text) - Ans.m02) < 0.01f && Mathf.Abs(float.Parse(Input[3].text) - Ans.m03) < 0.01f && Mathf.Abs(float.Parse(Input[4].text) - Ans.m10) < 0.01f && Mathf.Abs(float.Parse(Input[5].text) -Ans.m11) < 0.01f && Mathf.Abs(float.Parse(Input[6].text) -Ans.m12) < 0.01f && Mathf.Abs(float.Parse(Input[7].text) - Ans.m13) < 0.01f && Mathf.Abs(float.Parse(Input[8].text) - Ans.m20) < 0.01f && Mathf.Abs(float.Parse(Input[9].text) -Ans.m21) < 0.01f && Mathf.Abs(float.Parse(Input[10].text) - Ans.m22) < 0.01f && Mathf.Abs(float.Parse(Input[11].text) -Ans.m23) < 0.01f && Mathf.Abs(float.Parse(Input[12].text)-Ans.m30) < 0.01f && Mathf.Abs(float.Parse(Input[13].text)-Ans.m31) < 0.01f && Mathf.Abs(float.Parse(Input[14].text)-Ans.m32) < 0.01 && Mathf.Abs(float.Parse(Input[15].text) - Ans.m33) < 0.01f)
            {
                Correct.SetActive(true);
                Wrong.SetActive(false);
                //Hint2.SetActive(true);
                //Check.SetActive(false);
            }
            else
            {
                Wrong.SetActive(true);
                Correct.SetActive(false);

            }
        }
    }






}