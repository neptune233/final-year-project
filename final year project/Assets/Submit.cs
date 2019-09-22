using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Submit : MonoBehaviour
{

    public static int NumofMatrix;
    public Text numberofmatrix;

    public static Matrix4x4 Usermat1;
    public static Matrix4x4 Usermat2;
    public static Matrix4x4 Usermat3;
    public static Matrix4x4 Usermat4;

    public static Matrix4x4 Ans1; 
    public static Matrix4x4 Ans2;
    public static Matrix4x4 Ans3;
    public static Matrix4x4 Ans4;

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
    public static Matrix4x4 Userstep1;
    public static Matrix4x4 Userstep2;
    public static Matrix4x4 Userstep3;
    public static Matrix4x4 Userstep4;
    public GameObject Num_of_Step;
    public GameObject SubmitButton_S;
    public CanvasGroup submitbutton;
    public InputField[] M1;
    public InputField[] M2;
    public InputField[] M3;
    public InputField[] M4;
    public GameObject Matrix1;
    public GameObject Matrix2;
    public GameObject Matrix3;
    public GameObject Matrix4;
    public GameObject Instruction9;
    public GameObject SF;
    public GameObject Instruction10;
    public GameObject Instruction14;

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
                    Userstep1.m00 = 1;
                    Userstep1.m11 = 1;
                    Userstep1.m22 = 1;
                    Userstep1.m33 = 1;
                    Userstep1.m03 = x1;
                    Userstep1.m13 = y1;
                    Userstep1.m23 = z1;
                }
            }

            if (numberlist1.Length == 3)
            {
                if (float.TryParse(numberlist1[2], out temp )== true){
                    angle1 = float.Parse(numberlist1[2]);
                    angle1 = angle1 / 180 * Mathf.PI;
                    if (numberlist1[1].Equals("x"))
                    {
                        Userstep1.m00 = 1;
                        Userstep1.m11 = Mathf.Cos(angle1);
                        Userstep1.m12 = -Mathf.Sin(angle1);
                        Userstep1.m21 = Mathf.Sin(angle1);
                        Userstep1.m22 = Mathf.Cos(angle1);
                        Userstep1.m33 = 1;
                    }

                    if (numberlist1[1].Equals("y"))
                    {
                        Userstep1.m00 = Mathf.Cos(angle1);
                        Userstep1.m02 = Mathf.Sin(angle1);
                        Userstep1.m11 = 1;
                        Userstep1.m20 = -Mathf.Sin(angle1);
                        Userstep1.m22 = Mathf.Cos(angle1);
                        Userstep1.m33 = 1;
                    }
                    if (numberlist1[1].Equals("z"))
                    {
                        Userstep1.m00 = Mathf.Cos(angle1);
                        Userstep1.m11 = Mathf.Cos(angle1);
                        Userstep1.m01 = -Mathf.Sin(angle1);
                        Userstep1.m10 = Mathf.Sin(angle1);
                        Userstep1.m22 = 1;
                        Userstep1.m33 = 1;
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
                    Userstep2.m00 = 1;
                    Userstep2.m11 = 1;
                    Userstep2.m22 = 1;
                    Userstep2.m33 = 1;
                    Userstep2.m03 = x2;
                    Userstep2.m13 = y2;
                    Userstep2.m23 = z2;
                }
            }

            if (numberlist2.Length == 3)
            {
                if (float.TryParse(numberlist2[2], out temp) == true){
                    angle2 = float.Parse(numberlist2[2]);
                    angle2 = angle2 / 180 * Mathf.PI;
                    if (numberlist2[1].Equals("x"))
                    {
                        Userstep2.m00 = 1;
                        Userstep2.m11 = Mathf.Cos(angle2);
                        Userstep2.m12 = -Mathf.Sin(angle2);
                        Userstep2.m21 = Mathf.Sin(angle2);
                        Userstep2.m22 = Mathf.Cos(angle2);
                        Userstep2.m33 = 1;
                    }

                    if (numberlist2[1].Equals("y"))
                    {
                        Userstep2.m00 = Mathf.Cos(angle2);
                        Userstep2.m02 = Mathf.Sin(angle2);
                        Userstep2.m11 = 1;
                        Userstep2.m20 = -Mathf.Sin(angle2);
                        Userstep2.m22 = Mathf.Cos(angle2);
                        Userstep2.m33 = 1;
                    }
                    if (numberlist2[1].Equals("z"))
                    {
                        Userstep2.m00 = Mathf.Cos(angle2);
                        Userstep2.m11 = Mathf.Cos(angle2);
                        Userstep2.m01 = -Mathf.Sin(angle2);
                        Userstep2.m10 = Mathf.Sin(angle2);
                        Userstep2.m22 = 1;
                        Userstep2.m33 = 1;
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
                    Userstep3.m00 = 1;
                    Userstep3.m11 = 1;
                    Userstep3.m22 = 1;
                    Userstep3.m33 = 1;
                    Userstep3.m03 = x3;
                    Userstep3.m13 = y3;
                    Userstep3.m23 = z3;
                }
            }

            if (numberlist3.Length == 3)
            {
                if (float.TryParse(numberlist3[2], out temp) == true){
                    angle3 = float.Parse(numberlist3[2]);
                    angle3 = angle3 / 180 * Mathf.PI;
                    if (numberlist3[1].Equals("x"))
                    {
                        Userstep3.m00 = 1;
                        Userstep3.m11 = Mathf.Cos(angle3);
                        Userstep3.m12 = -Mathf.Sin(angle3);
                        Userstep3.m21 = Mathf.Sin(angle3);
                        Userstep3.m22 = Mathf.Cos(angle3);
                        Userstep3.m33 = 1;
                    }

                    if (numberlist3[1].Equals("y"))
                    {
                        Userstep3.m00 = Mathf.Cos(angle3);
                        Userstep3.m02 = Mathf.Sin(angle3);
                        Userstep3.m11 = 1;
                        Userstep3.m20 = -Mathf.Sin(angle3);
                        Userstep3.m22 = Mathf.Cos(angle3);
                        Userstep3.m33 = 1;
                    }
                    if (numberlist3[1].Equals("z"))
                    {
                        Userstep3.m00 = Mathf.Cos(angle3);
                        Userstep3.m11 = Mathf.Cos(angle3);
                        Userstep3.m01 = -Mathf.Sin(angle3);
                        Userstep3.m10 = Mathf.Sin(angle3);
                        Userstep3.m22 = 1;
                        Userstep3.m33 = 1;
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
                    Userstep4.m00 = 1;
                    Userstep4.m11 = 1;
                    Userstep4.m22 = 1;
                    Userstep4.m33 = 1;
                    Userstep4.m03 = x4;
                    Userstep4.m13 = y4;
                    Userstep4.m23 = z4;
                }
            }

            if (numberlist4.Length == 3)
            {
                if (float.TryParse(numberlist4[2], out temp) == true){
                    angle4 = float.Parse(numberlist4[2]);
                    angle4 = angle4 / 180 * Mathf.PI;
                    if (numberlist4[1].Equals("x"))
                    {
                        Userstep4.m00 = 1;
                        Userstep4.m11 = Mathf.Cos(angle4);
                        Userstep4.m12 = -Mathf.Sin(angle4);
                        Userstep4.m21 = Mathf.Sin(angle4);
                        Userstep4.m22 = Mathf.Cos(angle4);
                        Userstep4.m33 = 1;
                    }

                    if (numberlist4[1].Equals("y"))
                    {
                        Userstep4.m00 = Mathf.Cos(angle4);
                        Userstep4.m02 = Mathf.Sin(angle4);
                        Userstep4.m11 = 1;
                        Userstep4.m20 = -Mathf.Sin(angle4);
                        Userstep4.m22 = Mathf.Cos(angle4);
                        Userstep4.m33 = 1;
                    }
                    if (numberlist4[1].Equals("z"))
                    {
                        Userstep4.m00 = Mathf.Cos(angle4);
                        Userstep4.m11 = Mathf.Cos(angle4);
                        Userstep4.m01 = -Mathf.Sin(angle4);
                        Userstep4.m10 = Mathf.Sin(angle4);
                        Userstep4.m22 = 1;
                        Userstep4.m33 = 1;
                    }
                }
            }
        }
    }

    // Function which read the input matrix from users
    public void InputMatrix_16()
    {
        //data for matrix1
        float temp;
        bool error1 = true; // The bool which represents if the input is right or wrong
       
        for (int i = 0; i < 16; i++)
        {
            if (float.TryParse(M1[i].text, out temp) == false)
            {
                error1 = false;
                break;
                // If any input is not value type, the app will not accept the input
            }
        }
        if (error1 == true)
        {
            Usermat1.m00 = float.Parse(M1[0].text);
            Usermat1.m01 = float.Parse(M1[1].text);
            Usermat1.m02 = float.Parse(M1[2].text);
            Usermat1.m03 = float.Parse(M1[3].text);
            Usermat1.m10 = float.Parse(M1[4].text);
            Usermat1.m11 = float.Parse(M1[5].text);
            Usermat1.m12 = float.Parse(M1[6].text);
            Usermat1.m13 = float.Parse(M1[7].text);
            Usermat1.m20 = float.Parse(M1[8].text);
            Usermat1.m21 = float.Parse(M1[9].text);
            Usermat1.m22 = float.Parse(M1[10].text);
            Usermat1.m23 = float.Parse(M1[11].text);
            Usermat1.m30 = float.Parse(M1[12].text);
            Usermat1.m31 = float.Parse(M1[13].text);
            Usermat1.m32 = float.Parse(M1[14].text);
            Usermat1.m33 = float.Parse(M1[15].text);

            Ans1.m00 = 0.866f;
            Ans1.m01 = 0;
            Ans1.m02 = 0.5f;
            Ans1.m03 = 0;
            Ans1.m10 = 0;
            Ans1.m11 = 1;
            Ans1.m12 = 0;
            Ans1.m13 = 0;
            Ans1.m20 = -0.5f;
            Ans1.m21 = 0;
            Ans1.m22 = 0.866f;
            Ans1.m23 = 0;
            Ans1.m30 = 0;
            Ans1.m31 = 0;
            Ans1.m32 = 0;
            Ans1.m33 = 1;
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
            Usermat2.m00 = float.Parse(M2[0].text);
            Usermat2.m01 = float.Parse(M2[1].text);
            Usermat2.m02 = float.Parse(M2[2].text);
            Usermat2.m03 = float.Parse(M2[3].text);
            Usermat2.m10 = float.Parse(M2[4].text);
            Usermat2.m11 = float.Parse(M2[5].text);
            Usermat2.m12 = float.Parse(M2[6].text);
            Usermat2.m13 = float.Parse(M2[7].text);
            Usermat2.m20 = float.Parse(M2[8].text);
            Usermat2.m21 = float.Parse(M2[9].text);
            Usermat2.m22 = float.Parse(M2[10].text);
            Usermat2.m23 = float.Parse(M2[11].text);
            Usermat2.m30 = float.Parse(M2[12].text);
            Usermat2.m31 = float.Parse(M2[13].text);
            Usermat2.m32 = float.Parse(M2[14].text);
            Usermat2.m33 = float.Parse(M2[15].text);

            Ans2.m00 = 1;
            Ans2.m01 = 0;
            Ans2.m02 = 0;
            Ans2.m03 = 0;
            Ans2.m10 = 0;
            Ans2.m11 = 0.707f;
            Ans2.m12 = -0.707f;
            Ans2.m13 = 0;
            Ans2.m20 = 0;
            Ans2.m21 = 0.707f;
            Ans2.m22 = 0.707f;
            Ans2.m23 = 0;
            Ans2.m30 = 0;
            Ans2.m31 = 0;
            Ans2.m32 = 0;
            Ans2.m33 = 1;

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
            Usermat3.m00 = float.Parse(M3[0].text);
            Usermat3.m01 = float.Parse(M3[1].text);
            Usermat3.m02 = float.Parse(M3[2].text);
            Usermat3.m03 = float.Parse(M3[3].text);
            Usermat3.m10 = float.Parse(M3[4].text);
            Usermat3.m11 = float.Parse(M3[5].text);
            Usermat3.m12 = float.Parse(M3[6].text);
            Usermat3.m13 = float.Parse(M3[7].text);
            Usermat3.m20 = float.Parse(M3[8].text);
            Usermat3.m21 = float.Parse(M3[9].text);
            Usermat3.m22 = float.Parse(M3[10].text);
            Usermat3.m23 = float.Parse(M3[11].text);
            Usermat3.m30 = float.Parse(M3[12].text);
            Usermat3.m31 = float.Parse(M3[13].text);
            Usermat3.m32 = float.Parse(M3[14].text);
            Usermat3.m33 = float.Parse(M3[15].text);

            Ans3.m00 = 0.5f;
            Ans3.m01 = -0.866f;
            Ans3.m02 = 0;
            Ans3.m03 = 0;
            Ans3.m10 = 0.866f;
            Ans3.m11 = 0.5f;
            Ans3.m12 = 0;
            Ans3.m13 = 0;
            Ans3.m20 = 0;
            Ans3.m21 = 0;
            Ans3.m22 = 1;
            Ans3.m23 = 0;
            Ans3.m30 = 0;
            Ans3.m31 = 0;
            Ans3.m32 = 0;
            Ans3.m33 = 1;
        }

        //data for matrix4;
        /*
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
            Usermat4.m00 = float.Parse(M4[0].text);
            Usermat4.m01 = float.Parse(M4[1].text);
            Usermat4.m02 = float.Parse(M4[2].text);
            Usermat4.m03 = float.Parse(M4[3].text);
            Usermat4.m10 = float.Parse(M4[4].text);
            Usermat4.m11 = float.Parse(M4[5].text);
            Usermat4.m12 = float.Parse(M4[6].text);
            Usermat4.m13 = float.Parse(M4[7].text);
            Usermat4.m20 = float.Parse(M4[8].text);
            Usermat4.m21 = float.Parse(M4[9].text);
            Usermat4.m22 = float.Parse(M4[10].text);
            Usermat4.m23 = float.Parse(M4[11].text);
            Usermat4.m30 = float.Parse(M4[12].text);
            Usermat4.m31 = float.Parse(M4[13].text);
            Usermat4.m32 = float.Parse(M4[14].text);
            Usermat4.m33 = float.Parse(M4[15].text);
            Debug.Log(Usermat4);
        }
        */
        if(error1 && error2 && error3 )
        {
            Step1.SetActive(true);
           // Step2.SetActive(true);
           // Step3.SetActive(true);
            Matrix1.SetActive(false);
            Matrix2.SetActive(false);
            Matrix3.SetActive(false);
            Matrix4.SetActive(false);
            Instruction9.SetActive(false);
            submitbutton.alpha=0;
            SF.SetActive(false);
            Instruction10.SetActive(true);
            Instruction14.SetActive(true);
        }

    }
}









