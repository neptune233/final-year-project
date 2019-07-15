using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoveObejct_Directly : MonoBehaviour
{
    public GameObject cube;
    Quaternion q1;
    Vector3 v1;
    Quaternion q2;
    Vector3 v2;
    Quaternion q3;
    Vector3 v3;
    Quaternion q4;
    Vector3 v4;
    public GameObject ref1;
    public GameObject ref2;
    public GameObject ref3;
    public GameObject ref4;
    public static Vector3 Newposition1 = new Vector3(0, 0.3f, 0);
    public static Vector3 Newposition2 = new Vector3(0, 0.3f, 0);
    public static Vector3 Newposition3 = new Vector3(0, 0.3f, 0);
    public static Vector3 Newposition4 = new Vector3(0, 0.3f, 0);
    public CanvasGroup submitbutton;


    public void Onclick()
    {

        if (Submit.NumofStep == 1)
        {
            q1 = Transformation_Matrix.GetRotation(Submit.Caculate1);
            v1 = Transformation_Matrix.GetPostion(Submit.Caculate1) / 40;

            Newposition1 = Newposition1 + v1;
            Debug.Log(Newposition1);

        }
        if (Submit.NumofStep == 2)
        {
            q1 = Transformation_Matrix.GetRotation(Submit.Caculate1);
            v1 = Transformation_Matrix.GetPostion(Submit.Caculate1) / 40;

            q2 = Transformation_Matrix.GetRotation(Submit.Caculate1 * Submit.Caculate2);
            v2 = Transformation_Matrix.GetPostion(Submit.Caculate1 * Submit.Caculate2) / 40;

            Debug.Log(Submit.Caculate2);
            Newposition1 = Newposition1 + v1;
            Newposition2 = Newposition2 + v2;



        }
        if (Submit.NumofStep == 3)
        {
            q1 = Transformation_Matrix.GetRotation(Submit.Caculate1);
            v1 = Transformation_Matrix.GetPostion(Submit.Caculate1) / 40;

            q2 = Transformation_Matrix.GetRotation(Submit.Caculate1 * Submit.Caculate2);
            v2 = Transformation_Matrix.GetPostion(Submit.Caculate1 * Submit.Caculate2) / 40;



            q3 = Transformation_Matrix.GetRotation(Submit.Caculate1 * Submit.Caculate2 * Submit.Caculate3);
            v3 = Transformation_Matrix.GetPostion(Submit.Caculate1 * Submit.Caculate2 * Submit.Caculate3) / 40;



            Newposition1 = Newposition1 + v1;
            Newposition2 = Newposition2 + v2;
            Newposition3 = Newposition3 + v3;
        }
        if (Submit.NumofStep == 4)
        {
            q1 = Transformation_Matrix.GetRotation(Submit.Caculate1);
            v1 = Transformation_Matrix.GetPostion(Submit.Caculate1) / 40;

            q2 = Transformation_Matrix.GetRotation(Submit.Caculate1 * Submit.Caculate2);
            v2 = Transformation_Matrix.GetPostion(Submit.Caculate1 * Submit.Caculate2) / 40;

            q3 = Transformation_Matrix.GetRotation(Submit.Caculate1 * Submit.Caculate2 * Submit.Caculate3);
            v3 = Transformation_Matrix.GetPostion(Submit.Caculate1 * Submit.Caculate2 * Submit.Caculate3) / 40;

            
            Matrix4x4 a = Submit.Caculate1 * Submit.Caculate2 * Submit.Caculate3;
            a.m03 = Submit.Caculate4.m03;
            a.m13 = Submit.Caculate4.m13;
            a.m23 = Submit.Caculate4.m23;

            q4 = Transformation_Matrix.GetRotation(a);
            v4 = Transformation_Matrix.GetPostion(a) / 40;


            Newposition1 = Newposition1 + v1;
            Newposition2 = Newposition2 + v2;
            Newposition3 = Newposition3 + v3;
            Newposition4 = Newposition4 + v4;
        }

    }


    void FixedUpdate()
    {

        if (Submit.NumofStep == 1)
        {
            if (Buttonid.Step == 1)
            {
                cube.transform.localPosition = Vector3.Lerp(cube.transform.localPosition, Newposition1, Time.deltaTime / 3);
                cube.transform.localRotation = Quaternion.Slerp(cube.transform.localRotation, q1, Time.deltaTime / 3);
            }
        }



        if (Submit.NumofStep == 2)
        {
            if (Buttonid.Step == 1)
            {
                cube.transform.localPosition = Vector3.Lerp(cube.transform.localPosition, Newposition1, Time.deltaTime / 3);
                cube.transform.localRotation = Quaternion.Slerp(cube.transform.localRotation, q1, Time.deltaTime / 3);
            }

            if (Buttonid.Step == 2)
            {
                cube.transform.localPosition = Vector3.Lerp(cube.transform.localPosition, Newposition2, Time.deltaTime / 3);
                cube.transform.localRotation = Quaternion.Slerp(cube.transform.localRotation, q2, Time.deltaTime / 3);
            }
        }

        if (Submit.NumofStep == 3)
        {
            if (Buttonid.Step == 1)
            {
                cube.transform.localPosition = Vector3.Lerp(cube.transform.localPosition, Newposition1, Time.deltaTime / 3);
                cube.transform.localRotation = Quaternion.Slerp(cube.transform.localRotation, q1, Time.deltaTime / 3);
            }

            if (Buttonid.Step == 2)
            {
                cube.transform.localPosition = Vector3.Lerp(cube.transform.localPosition, Newposition2, Time.deltaTime / 3);
                cube.transform.localRotation = Quaternion.Slerp(cube.transform.localRotation, q2, Time.deltaTime / 3);
            }

            if (Buttonid.Step == 3)
            {
                cube.transform.localPosition = Vector3.Lerp(cube.transform.localPosition, Newposition3, Time.deltaTime / 3);
                cube.transform.localRotation = Quaternion.Slerp(cube.transform.localRotation, q3, Time.deltaTime / 3);
            }
        }


        if (Submit.NumofStep == 4)
        {
            if (Buttonid.Step == 1)
            {
                ref1.SetActive(true);
                ref2.SetActive(false);
                ref3.SetActive(false);
                ref4.SetActive(false);
                cube.transform.localPosition = Vector3.Lerp(cube.transform.localPosition, Newposition1, Time.deltaTime / 3);
                cube.transform.localRotation = Quaternion.Slerp(cube.transform.localRotation, q1, Time.deltaTime / 3);
            }

            if (Buttonid.Step == 2)
            {
                ref1.SetActive(false);
                ref2.SetActive(true);
                ref3.SetActive(false);
                ref4.SetActive(false);
                cube.transform.localPosition = Vector3.Lerp(cube.transform.localPosition, Newposition2, Time.deltaTime / 3);
                cube.transform.localRotation = Quaternion.Slerp(cube.transform.localRotation, q2, Time.deltaTime / 3);
            }

            if (Buttonid.Step == 3)
            {
                ref1.SetActive(false);
                ref2.SetActive(false);
                ref3.SetActive(true);
                ref4.SetActive(false);
                cube.transform.localPosition = Vector3.Lerp(cube.transform.localPosition, Newposition3, Time.deltaTime / 3);
                cube.transform.localRotation = Quaternion.Slerp(cube.transform.localRotation, q3, Time.deltaTime / 3);
            }

            if (Buttonid.Step == 4)
            {
                ref1.SetActive(false);
                ref2.SetActive(false);
                ref3.SetActive(false);
                ref4.SetActive(true);
                cube.transform.localPosition = Vector3.Lerp(cube.transform.localPosition, Newposition4, Time.deltaTime / 3);
                cube.transform.localRotation = Quaternion.Slerp(cube.transform.localRotation, q4, Time.deltaTime / 3);
            }
        }




    }

    public void Hide()
    {
        submitbutton.alpha = 0.0f;
    }
  
        
}
