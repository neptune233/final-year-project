using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Submit : MonoBehaviour
{

    public static int NumofMatrix;
    public Text numberofmatrix;

    public static Matrix4x4 Output1;
    public static Matrix4x4 Output2;
    public static Matrix4x4 Output3;
    public static Matrix4x4 Output4;
    public GameObject Num_of_Matrix;
    public GameObject SubmitButton_M;


    public static int NumofStep;
    public Text numberofstep;
    public Text step1;
    public Text step2;
    public Text step3;
    public Text step4;
    public GameObject Step1;
    public GameObject Step2;
    public GameObject Step3;
    public GameObject Step4;
    public static Matrix4x4 Caculate1;
    public static Matrix4x4 Caculate2;
    public static Matrix4x4 Caculate3;
    public static Matrix4x4 Caculate4;
    public GameObject Num_of_Step;
    public GameObject SubmitButton_S;

    public InputField[] M1;
    public InputField[] M2;
    public InputField[] M3;
    public InputField[] M4;
    public GameObject Matrix1;
    public GameObject Matrix2;
    public GameObject Matrix3;
    public GameObject Matrix4;



    // input the number of matrix
    public void Number_of_Matrix()
    {
        int test;

        if (int.TryParse(numberofmatrix.text, out test) == true)
        {
            NumofMatrix = int.Parse(numberofmatrix.text);
            //Debug.Log(NumofMatrix);
        }
    }

    // input the number of step
    public void Number_of_Step()
    {
        int test;
        if (int.TryParse(numberofstep.text, out test) == true)
        {
            NumofStep = int.Parse(numberofstep.text);
            //Debug.Log(NumofMatrix);
        }
    }

    // show the matrices inputfield with corrct number
    public void Show_Matrix()
    {
        
        if (NumofMatrix >= 1 && NumofMatrix <= 4)
        {

            //SubmitButton_M.SetActive(true);
            Num_of_Matrix.SetActive(false);
            if (NumofMatrix == 1)
            {
                Matrix1.SetActive(true);

            }
            if (NumofMatrix == 2)
            {
                Matrix1.SetActive(true);
                Matrix2.SetActive(true);
            }
            if (NumofMatrix == 3)
            {
                Matrix1.SetActive(true);
                Matrix2.SetActive(true);
                Matrix3.SetActive(true);
            }
            if (NumofMatrix == 4)
            {
                Matrix1.SetActive(true);
                Matrix2.SetActive(true);
                Matrix3.SetActive(true);
                Matrix4.SetActive(true);
            }
        }
    }

    // show the steps inputfield with corrct number
    public void Show_Step()
    {
        Scene scene = SceneManager.GetActiveScene();
        if (scene.name.Equals("3"))
        {
            if (NumofStep >= 1 && NumofStep <= 4)
            {
                SubmitButton_S.SetActive(true);
                Num_of_Step.SetActive(false);
                if (NumofStep == 1)
                {
                    Step1.SetActive(true);

                }
                if (NumofStep == 2)
                {
                    Step1.SetActive(true);
                    Step2.SetActive(true);
                }
                if (NumofStep == 3)
                {
                    Step1.SetActive(true);
                    Step2.SetActive(true);
                    Step3.SetActive(true);
                }
                if (NumofStep == 4)
                {
                    Step1.SetActive(true);
                    Step2.SetActive(true);
                    Step3.SetActive(true);
                    Step4.SetActive(true);
                }
            }
        }
        if (scene.name.Equals("1"))
        {
            if (NumofStep == 1)
            {
                Step1.SetActive(true);

            }
            if (NumofStep == 2)
            {
                Step1.SetActive(true);
                Step2.SetActive(true);
            }
            if (NumofStep == 3)
            {
                Step1.SetActive(true);
                Step2.SetActive(true);
                Step3.SetActive(true);
            }
            if (NumofStep == 4)
            {
                Step1.SetActive(true);
                Step2.SetActive(true);
                Step3.SetActive(true);
                Step4.SetActive(true);
            }
        }

    }

    // input the value into matrix
    
    /*
    public void InputMatrix()
    {
        //data for matrix1
        string Data1 = matrix1.text;
        string[] numberlist1 = Data1.Split();
        //Debug.Log(float.Parse(numberlist1[14]));
        bool error1 = true;
        float temp;
        for (int i = 0; i < numberlist1.Length; i++)
        {
            if (float.TryParse(numberlist1[i], out temp) == false)
            {
                error1 = false;
                break;
            }
        }
        if (error1 == true)
        {
            Output1.m00 = float.Parse(numberlist1[0]);
            Output1.m01 = float.Parse(numberlist1[1]);
            Output1.m02 = float.Parse(numberlist1[2]);
            Output1.m03 = float.Parse(numberlist1[3]);
            Output1.m10 = float.Parse(numberlist1[4]);
            Output1.m11 = float.Parse(numberlist1[5]);
            Output1.m12 = float.Parse(numberlist1[6]);
            Output1.m13 = float.Parse(numberlist1[7]);
            Output1.m20 = float.Parse(numberlist1[8]);
            Output1.m21 = float.Parse(numberlist1[9]);
            Output1.m22 = float.Parse(numberlist1[10]);
            Output1.m23 = float.Parse(numberlist1[11]);
            Output1.m30 = float.Parse(numberlist1[12]);
            Output1.m31 = float.Parse(numberlist1[13]);
            Output1.m32 = float.Parse(numberlist1[14]);
            Output1.m33 = float.Parse(numberlist1[15]);
            Debug.Log(Output1);
        }

        //data for matrix2

        string Data2 = matrix2.text;
        string[] numberlist2 = Data2.Split();
        bool error2 = true;

        for (int i = 0; i < numberlist2.Length; i++)
        {
            if (float.TryParse(numberlist2[i], out temp) == false)
            {
                error2 = false;
                break;
            }
        }
        if (error2 == true)
        {
            Output2.m00 = float.Parse(numberlist2[0]);
            Output2.m01 = float.Parse(numberlist2[1]);
            Output2.m02 = float.Parse(numberlist2[2]);
            Output2.m03 = float.Parse(numberlist2[3]);
            Output2.m10 = float.Parse(numberlist2[4]);
            Output2.m11 = float.Parse(numberlist2[5]);
            Output2.m12 = float.Parse(numberlist2[6]);
            Output2.m13 = float.Parse(numberlist2[7]);
            Output2.m20 = float.Parse(numberlist2[8]);
            Output2.m21 = float.Parse(numberlist2[9]);
            Output2.m22 = float.Parse(numberlist2[10]);
            Output2.m23 = float.Parse(numberlist2[11]);
            Output2.m30 = float.Parse(numberlist2[12]);
            Output2.m31 = float.Parse(numberlist2[13]);
            Output2.m32 = float.Parse(numberlist2[14]);
            Output2.m33 = float.Parse(numberlist2[15]);
            Debug.Log(Output2);
        }

        //data for matrix3
        string Data3 = matrix3.text;
        string[] numberlist3 = Data3.Split();
        bool error3 = true;

        for (int i = 0; i < numberlist3.Length; i++)
        {
            if (float.TryParse(numberlist3[i], out temp) == false)
            {
                error3 = false;
                break;
            }
        }
        if (error3 == true)
        {
            Output3.m00 = float.Parse(numberlist3[0]);
            Output3.m01 = float.Parse(numberlist3[1]);
            Output3.m02 = float.Parse(numberlist3[2]);
            Output3.m03 = float.Parse(numberlist3[3]);
            Output3.m10 = float.Parse(numberlist3[4]);
            Output3.m11 = float.Parse(numberlist3[5]);
            Output3.m12 = float.Parse(numberlist3[6]);
            Output3.m13 = float.Parse(numberlist3[7]);
            Output3.m20 = float.Parse(numberlist3[8]);
            Output3.m21 = float.Parse(numberlist3[9]);
            Output3.m22 = float.Parse(numberlist3[10]);
            Output3.m23 = float.Parse(numberlist3[11]);
            Output3.m30 = float.Parse(numberlist3[12]);
            Output3.m31 = float.Parse(numberlist3[13]);
            Output3.m32 = float.Parse(numberlist3[14]);
            Output3.m33 = float.Parse(numberlist3[15]);
        }

        //data for matrix4
        string Data4 = matrix4.text;
        string[] numberlist4 = Data4.Split();
        bool error4 = true;

        for (int i = 0; i < numberlist4.Length; i++)
        {
            if (float.TryParse(numberlist4[i], out temp) == false)
            {
                error4 = false;
                break;
            }
        }
        if (error4 == true)
        {
            Output4.m00 = float.Parse(numberlist4[0]);
            Output4.m01 = float.Parse(numberlist4[1]);
            Output4.m02 = float.Parse(numberlist4[2]);
            Output4.m03 = float.Parse(numberlist4[3]);
            Output4.m10 = float.Parse(numberlist4[4]);
            Output4.m11 = float.Parse(numberlist4[5]);
            Output4.m12 = float.Parse(numberlist4[6]);
            Output4.m13 = float.Parse(numberlist4[7]);
            Output4.m20 = float.Parse(numberlist4[8]);
            Output4.m21 = float.Parse(numberlist4[9]);
            Output4.m22 = float.Parse(numberlist4[10]);
            Output4.m23 = float.Parse(numberlist4[11]);
            Output4.m30 = float.Parse(numberlist4[12]);
            Output4.m31 = float.Parse(numberlist4[13]);
            Output4.m32 = float.Parse(numberlist4[14]);
            Output4.m33 = float.Parse(numberlist4[15]);
        }

    }
    */

    // convert the input of directly step
    public void InputStep()
    {
        string Data1 = step1.text;
        string[] numberlist1 = Data1.Split();
        float x1, y1, z1;
        float temp, temp1, temp2, temp3;
        float angle1;
        if (numberlist1.Length != 0)
        {
            if (numberlist1.Length == 4)
            {
                if (float.TryParse(numberlist1[1], out temp1) == true && 
                    float.TryParse(numberlist1[2], out temp2) == true && 
                    float.TryParse(numberlist1[3], out temp3) == true)
                {
                    x1 = float.Parse(numberlist1[1]);
                    y1 = float.Parse(numberlist1[2]);
                    z1 = float.Parse(numberlist1[3]);
                    Caculate1.m00 = 1;
                    Caculate1.m11 = 1;
                    Caculate1.m22 = 1;
                    Caculate1.m33 = 1;
                    Caculate1.m03 = x1;
                    Caculate1.m13 = y1;
                    Caculate1.m23 = z1;
                }
            }

            if (numberlist1.Length == 3)
            {
                if (float.TryParse(numberlist1[2], out temp )== true){
                    angle1 = float.Parse(numberlist1[2]);
                    angle1 = angle1 / 180 * Mathf.PI;
                    if (numberlist1[1].Equals("x"))
                    {
                        Caculate1.m00 = 1;
                        Caculate1.m11 = Mathf.Cos(angle1);
                        Caculate1.m12 = -Mathf.Sin(angle1);
                        Caculate1.m21 = Mathf.Sin(angle1);
                        Caculate1.m22 = Mathf.Cos(angle1);
                        Caculate1.m33 = 1;
                    }

                    if (numberlist1[1].Equals("y"))
                    {
                        Caculate1.m00 = Mathf.Cos(angle1);
                        Caculate1.m02 = Mathf.Sin(angle1);
                        Caculate1.m11 = 1;
                        Caculate1.m20 = -Mathf.Sin(angle1);
                        Caculate1.m22 = Mathf.Cos(angle1);
                        Caculate1.m33 = 1;
                    }
                    if (numberlist1[1].Equals("z"))
                    {
                        Caculate1.m00 = Mathf.Cos(angle1);
                        Caculate1.m11 = Mathf.Cos(angle1);
                        Caculate1.m01 = -Mathf.Sin(angle1);
                        Caculate1.m10 = Mathf.Sin(angle1);
                        Caculate1.m22 = 1;
                        Caculate1.m33 = 1;
                    }
                }
            }
        }

        string Data2 = step2.text;
        string[] numberlist2 = Data2.Split();
        float x2, y2, z2;
       // float temp, temp1, temp2, temp3;
        float angle2;
        if (numberlist2.Length != 0)
        {
            if (numberlist2.Length == 4)
            {
                if (float.TryParse(numberlist2[1], out temp1) == true && float.TryParse(numberlist2[2], out temp2) == true && float.TryParse(numberlist2[3], out temp3) == true)
                {
                    x2 = float.Parse(numberlist2[1]);
                    y2 = float.Parse(numberlist2[2]);
                    z2 = float.Parse(numberlist2[3]);
                    Caculate2.m00 = 1;
                    Caculate2.m11 = 1;
                    Caculate2.m22 = 1;
                    Caculate2.m33 = 1;
                    Caculate2.m03 = x2;
                    Caculate2.m13 = y2;
                    Caculate2.m23 = z2;
                }
            }

            if (numberlist2.Length == 3)
            {
                if (float.TryParse(numberlist2[2], out temp) == true){
                    angle2 = float.Parse(numberlist2[2]);
                    angle2 = angle2 / 180 * Mathf.PI;
                    if (numberlist2[1].Equals("x"))
                    {
                        Caculate2.m00 = 1;
                        Caculate2.m11 = Mathf.Cos(angle2);
                        Caculate2.m12 = -Mathf.Sin(angle2);
                        Caculate2.m21 = Mathf.Sin(angle2);
                        Caculate2.m22 = Mathf.Cos(angle2);
                        Caculate2.m33 = 1;
                    }

                    if (numberlist2[1].Equals("y"))
                    {
                        Caculate2.m00 = Mathf.Cos(angle2);
                        Caculate2.m02 = Mathf.Sin(angle2);
                        Caculate2.m11 = 1;
                        Caculate2.m20 = -Mathf.Sin(angle2);
                        Caculate2.m22 = Mathf.Cos(angle2);
                        Caculate2.m33 = 1;
                    }
                    if (numberlist2[1].Equals("z"))
                    {
                        Caculate2.m00 = Mathf.Cos(angle2);
                        Caculate2.m11 = Mathf.Cos(angle2);
                        Caculate2.m01 = -Mathf.Sin(angle2);
                        Caculate2.m10 = Mathf.Sin(angle2);
                        Caculate2.m22 = 1;
                        Caculate2.m33 = 1;
                    }
                }
            }
        }

        string Data3 = step3.text;
        string[] numberlist3 = Data3.Split();
        float x3, y3, z3;
       // float temp, temp1, temp2, temp3;
        float angle3;
        if (numberlist3.Length != 0)
        {
            if (numberlist3.Length == 4)
            {
                if (float.TryParse(numberlist3[1], out temp1) == true && float.TryParse(numberlist3[2], out temp2) == true && float.TryParse(numberlist3[3], out temp3) == true)
                {
                    x3 = float.Parse(numberlist3[1]);
                    y3 = float.Parse(numberlist3[2]);
                    z3 = float.Parse(numberlist3[3]);
                    Caculate3.m00 = 1;
                    Caculate3.m11 = 1;
                    Caculate3.m22 = 1;
                    Caculate3.m33 = 1;
                    Caculate3.m03 = x3;
                    Caculate3.m13 = y3;
                    Caculate3.m23 = z3;
                }
            }

            if (numberlist3.Length == 3)
            {
                if (float.TryParse(numberlist3[2], out temp) == true){
                    angle3 = float.Parse(numberlist3[2]);
                    angle3 = angle3 / 180 * Mathf.PI;
                    if (numberlist3[1].Equals("x"))
                    {
                        Caculate3.m00 = 1;
                        Caculate3.m11 = Mathf.Cos(angle3);
                        Caculate3.m12 = -Mathf.Sin(angle3);
                        Caculate3.m21 = Mathf.Sin(angle3);
                        Caculate3.m22 = Mathf.Cos(angle3);
                        Caculate3.m33 = 1;
                    }

                    if (numberlist3[1].Equals("y"))
                    {
                        Caculate3.m00 = Mathf.Cos(angle3);
                        Caculate3.m02 = Mathf.Sin(angle3);
                        Caculate3.m11 = 1;
                        Caculate3.m20 = -Mathf.Sin(angle3);
                        Caculate3.m22 = Mathf.Cos(angle3);
                        Caculate3.m33 = 1;
                    }
                    if (numberlist3[1].Equals("z"))
                    {
                        Caculate3.m00 = Mathf.Cos(angle3);
                        Caculate3.m11 = Mathf.Cos(angle3);
                        Caculate3.m01 = -Mathf.Sin(angle3);
                        Caculate3.m10 = Mathf.Sin(angle3);
                        Caculate3.m22 = 1;
                        Caculate3.m33 = 1;
                    }
                }
            }
        }

        string Data4 = step4.text;
        string[] numberlist4 = Data4.Split();
        float x4, y4, z4;
        //float temp, temp1, temp2, temp3;
        float angle4;
        if (numberlist4.Length != 0)
        {
            if (numberlist4.Length == 4)
            {
                if (float.TryParse(numberlist4[1], out temp1) == true && float.TryParse(numberlist4[2], out temp2) == true && float.TryParse(numberlist4[3], out temp3) == true)
                {
                    x4 = float.Parse(numberlist4[1]);
                    y4 = float.Parse(numberlist4[2]);
                    z4 = float.Parse(numberlist4[3]);
                    Caculate4.m00 = 1;
                    Caculate4.m11 = 1;
                    Caculate4.m22 = 1;
                    Caculate4.m33 = 1;
                    Caculate4.m03 = x4;
                    Caculate4.m13 = y4;
                    Caculate4.m23 = z4;
                }
            }

            if (numberlist4.Length == 3)
            {
                if (float.TryParse(numberlist4[2], out temp) == true){
                    angle4 = float.Parse(numberlist4[2]);
                    angle4 = angle4 / 180 * Mathf.PI;
                    if (numberlist4[1].Equals("x"))
                    {
                        Caculate4.m00 = 1;
                        Caculate4.m11 = Mathf.Cos(angle4);
                        Caculate4.m12 = -Mathf.Sin(angle4);
                        Caculate4.m21 = Mathf.Sin(angle4);
                        Caculate4.m22 = Mathf.Cos(angle4);
                        Caculate4.m33 = 1;
                    }

                    if (numberlist4[1].Equals("y"))
                    {
                        Caculate4.m00 = Mathf.Cos(angle4);
                        Caculate4.m02 = Mathf.Sin(angle4);
                        Caculate4.m11 = 1;
                        Caculate4.m20 = -Mathf.Sin(angle4);
                        Caculate4.m22 = Mathf.Cos(angle4);
                        Caculate4.m33 = 1;
                    }
                    if (numberlist4[1].Equals("z"))
                    {
                        Caculate4.m00 = Mathf.Cos(angle4);
                        Caculate4.m11 = Mathf.Cos(angle4);
                        Caculate4.m01 = -Mathf.Sin(angle4);
                        Caculate4.m10 = Mathf.Sin(angle4);
                        Caculate4.m22 = 1;
                        Caculate4.m33 = 1;
                    }
                }
            }
        }
    }
    public void InputMatrix_16()
    {
        //data for matrix1
        bool error1 = true;
        float temp;
        for (int i = 0; i < 16; i++)
        {
            if (float.TryParse(M1[i].text, out temp) == false)
            {
                error1 = false;
                break;
            }
        }
        if (error1 == true)
        {
            Output1.m00 = float.Parse(M1[0].text);
            Output1.m01 = float.Parse(M1[1].text);
            Output1.m02 = float.Parse(M1[2].text);
            Output1.m03 = float.Parse(M1[3].text);
            Output1.m10 = float.Parse(M1[4].text);
            Output1.m11 = float.Parse(M1[5].text);
            Output1.m12 = float.Parse(M1[6].text);
            Output1.m13 = float.Parse(M1[7].text);
            Output1.m20 = float.Parse(M1[8].text);
            Output1.m21 = float.Parse(M1[9].text);
            Output1.m22 = float.Parse(M1[10].text);
            Output1.m23 = float.Parse(M1[11].text);
            Output1.m30 = float.Parse(M1[12].text);
            Output1.m31 = float.Parse(M1[13].text);
            Output1.m32 = float.Parse(M1[14].text);
            Output1.m33 = float.Parse(M1[15].text);
            Debug.Log(Output1);
        }

        //data for matrix2
        bool error2 = true;
        for (int i = 0; i < 16; i++)
        {
            if (float.TryParse(M2[i].text, out temp) == false)
            {
                error2 = false;
                break;
            }
        }
        if (error2 == true)
        {
            Output2.m00 = float.Parse(M2[0].text);
            Output2.m01 = float.Parse(M2[1].text);
            Output2.m02 = float.Parse(M2[2].text);
            Output2.m03 = float.Parse(M2[3].text);
            Output2.m10 = float.Parse(M2[4].text);
            Output2.m11 = float.Parse(M2[5].text);
            Output2.m12 = float.Parse(M2[6].text);
            Output2.m13 = float.Parse(M2[7].text);
            Output2.m20 = float.Parse(M2[8].text);
            Output2.m21 = float.Parse(M2[9].text);
            Output2.m22 = float.Parse(M2[10].text);
            Output2.m23 = float.Parse(M2[11].text);
            Output2.m30 = float.Parse(M2[12].text);
            Output2.m31 = float.Parse(M2[13].text);
            Output2.m32 = float.Parse(M2[14].text);
            Output2.m33 = float.Parse(M2[15].text);
            Debug.Log(Output2);
        }

        //data for matrix3
        bool error3 = true;
        for (int i = 0; i < 16; i++)
        {
            if (float.TryParse(M3[i].text, out temp) == false)
            {
                error3 = false;
                break;
            }
        }
        if (error3 == true)
        {
            Output3.m00 = float.Parse(M3[0].text);
            Output3.m01 = float.Parse(M3[1].text);
            Output3.m02 = float.Parse(M3[2].text);
            Output3.m03 = float.Parse(M3[3].text);
            Output3.m10 = float.Parse(M3[4].text);
            Output3.m11 = float.Parse(M3[5].text);
            Output3.m12 = float.Parse(M3[6].text);
            Output3.m13 = float.Parse(M3[7].text);
            Output3.m20 = float.Parse(M3[8].text);
            Output3.m21 = float.Parse(M3[9].text);
            Output3.m22 = float.Parse(M3[10].text);
            Output3.m23 = float.Parse(M3[11].text);
            Output3.m30 = float.Parse(M3[12].text);
            Output3.m31 = float.Parse(M3[13].text);
            Output3.m32 = float.Parse(M3[14].text);
            Output3.m33 = float.Parse(M3[15].text);
            Debug.Log(Output3);
        }

        //data for matrix4;
        bool error4 = true;
        for (int i = 0; i < 16; i++)
        {
            if (float.TryParse(M4[i].text, out temp) == false)
            {
                error4 = false;
                break;
            }
        }
        if (error4 == true)
        {
            Output4.m00 = float.Parse(M4[0].text);
            Output4.m01 = float.Parse(M4[1].text);
            Output4.m02 = float.Parse(M4[2].text);
            Output4.m03 = float.Parse(M4[3].text);
            Output4.m10 = float.Parse(M4[4].text);
            Output4.m11 = float.Parse(M4[5].text);
            Output4.m12 = float.Parse(M4[6].text);
            Output4.m13 = float.Parse(M4[7].text);
            Output4.m20 = float.Parse(M4[8].text);
            Output4.m21 = float.Parse(M4[9].text);
            Output4.m22 = float.Parse(M4[10].text);
            Output4.m23 = float.Parse(M4[11].text);
            Output4.m30 = float.Parse(M4[12].text);
            Output4.m31 = float.Parse(M4[13].text);
            Output4.m32 = float.Parse(M4[14].text);
            Output4.m33 = float.Parse(M4[15].text);
            Debug.Log(Output4);
        }
    }
}









