using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;



public class Quiz : MonoBehaviour
{
    /*
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
    */
    public CanvasGroup Newquestion;
    public GameObject Q1;
    public GameObject Animate1;
    public GameObject Animate2;
    public GameObject Animate3;
    public Matrix4x4 M1;
    public Matrix4x4 M2;
    public Matrix4x4 M3;
   

    public static bool Iscreated1 = true;
    public static bool Iscreated2 = true;
    public static bool Iscreated3 = true;

    public GameObject User;
    public Transform imagetarget; 
    public Transform Cam;
    public GameObject UserxRef;
    public GameObject UseryRef;
    public GameObject UserzRef;

    Quaternion q1;
    Quaternion q2;
    Quaternion q3;

    public GameObject Step2;
    public GameObject Step3;

    public static float Timer1=0;
    public static float Timer2=0;
    public static float Timer3=0;

    public GameObject Clock;
    public Text Number;
    



    // function when press the leftarrow
    /*
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
    */


    ///////////////////
    public void Question1()
    {
        System.Random ran = new System.Random();
        string[] angle= { "30", "45", "60", "90" };
        string[] xyz = new string[3];
        for(int i=0;i<3;i++)
        {
            xyz[i]= angle[ran.Next(0, 4)];
        }

        Q1.GetComponent<TMPro.TextMeshProUGUI>().text = "Frame{B} is initally coincident with world coordinate system. Frame{B} is rotated about y axis itself by " + xyz[0] + " degree ,then rotated about x axis itself by " + xyz[1] + " degree,then about z aixs itself by " + xyz[2] + " degree. ";
        Animate1.GetComponent<TMPro.TextMeshProUGUI>().text = "1.Rotate about\n y axis by " + xyz[0];
        Animate2.GetComponent<TMPro.TextMeshProUGUI>().text = "2.Rotate about\n x axis by " + xyz[1];
        Animate3.GetComponent<TMPro.TextMeshProUGUI>().text = "3.Rotate about\n z axis by " + xyz[2];

        float angle1;
        float angle2;
        float angle3;
        angle1 = float.Parse(xyz[0]) / 180 * Mathf.PI;
        Debug.Log(angle1);
        angle2 = float.Parse(xyz[1]) / 180 * Mathf.PI;
        Debug.Log(angle2);
        angle3 = float.Parse(xyz[2]) / 180 * Mathf.PI;
        Debug.Log(angle3);


        M1.m00 = Mathf.Cos(angle1);
        M1.m02 = Mathf.Sin(angle1);
        M1.m11 = 1;
        M1.m20 = -Mathf.Sin(angle1);
        M1.m22 = Mathf.Cos(angle1);
        M1.m33 = 1;

        M2.m00 = 1;
        M2.m11 = Mathf.Cos(angle2);
        M2.m12 = -Mathf.Sin(angle2);
        M2.m21 = Mathf.Sin(angle2);
        M2.m22 = Mathf.Cos(angle2);
        M2.m33 = 1;

        M3.m00 = Mathf.Cos(angle3);
        M3.m11 = Mathf.Cos(angle3);
        M3.m01 = -Mathf.Sin(angle3);
        M3.m10 = Mathf.Sin(angle3);
        M3.m22 = 1;
        M3.m33 = 1;

        q1 = Transformation_Matrix.GetRotation(M1);
        q2 = Transformation_Matrix.GetRotation(M1 * M2);
        q3 = Transformation_Matrix.GetRotation(M1 * M2 * M3);

        Newquestion.alpha = 0;

        Timer1 = 0;
        Timer2 = 0;
        Timer3 = 0;
        Iscreated1 = true;
        Iscreated2 = true;
        Iscreated3 = true;
        Buttonid.Step = 0;
    }


    void FixedUpdate()
    {


        if (Timer1 > 8)
        {

            Step2.SetActive(true);
        }
        if (Timer2 > 8)
        {

            Step3.SetActive(true);
        }
        if (Timer3 > 8)
        {
            Newquestion.alpha = 1;
        }

        // Case when only one matrix is input



        if (Buttonid.Step == 1)
        {
            Timer1 = Timer1 + Time.deltaTime;
            if (Timer1 <= 8)
            {
                Number.text = (8 - Timer1).ToString("f1");
            }

            Clock.GetComponent<Image>().fillAmount = 1 - Timer1 / 8;
            if (Iscreated1)
            {
                Iscreated1 = false;
                var clone1 = Instantiate(User, imagetarget);

                clone1.name = "ref1";
            }

            Quaternion lastRotation = Cam.rotation;

            UserxRef.transform.rotation = lastRotation;
            UseryRef.transform.rotation = lastRotation;
            UserzRef.transform.rotation = lastRotation;



            if (GameObject.Find("ImageTarget/ref1") == true)
            {
                UserxRef.transform.position = GameObject.Find("ImageTarget/ref1/x-axis/Userxcoor").gameObject.transform.position;
                UseryRef.transform.position = GameObject.Find("ImageTarget/ref1/y-axis/Userycoor").gameObject.transform.position;
                UserzRef.transform.position = GameObject.Find("ImageTarget/ref1/z-axis/Userzcoor").gameObject.transform.position;
                GameObject.Find("ImageTarget/ref1/x-axis/Cylinder").gameObject.GetComponent<Renderer>().material.color = new Color(255, 0, 0, 0.3f);
                GameObject.Find("ImageTarget/ref1/y-axis/Cylinder").gameObject.GetComponent<Renderer>().material.color = new Color(0, 255, 0, 0.3f);
                GameObject.Find("ImageTarget/ref1/z-axis/Cylinder").gameObject.GetComponent<Renderer>().material.color = new Color(0, 0, 255, 0.3f);

            }
            Debug.Log(q1);
            User.transform.localRotation = Quaternion.Slerp(User.transform.localRotation, q1, Time.deltaTime / 3);
        }

        if (Buttonid.Step == 2)
        {
            Timer2 = Timer2 + Time.deltaTime;
            if (Timer2 <= 8)
            {
                Number.text = (8 - Timer2).ToString("f1");
            }
            Clock.GetComponent<Image>().fillAmount = 1 - Timer2 / 8;
            if (Iscreated2)
            {
                if (GameObject.Find("ref1"))
                {
                    Destroy(GameObject.Find("ref1").gameObject);
                }
                if (GameObject.Find("ansref1"))
                {
                    Destroy(GameObject.Find("ansref1").gameObject);
                }
                var clone1 = Instantiate(User, imagetarget);
                clone1.name = "ref2";
                Iscreated2 = false;
            }

            Quaternion lastRotation = Cam.rotation;

            UserxRef.transform.rotation = lastRotation;
            UseryRef.transform.rotation = lastRotation;
            UserzRef.transform.rotation = lastRotation;


            if (GameObject.Find("ImageTarget/ref2") == true)
            {
                UserxRef.transform.position = GameObject.Find("ImageTarget/ref2/x-axis/Userxcoor").gameObject.transform.position;
                UseryRef.transform.position = GameObject.Find("ImageTarget/ref2/y-axis/Userycoor").gameObject.transform.position;
                UserzRef.transform.position = GameObject.Find("ImageTarget/ref2/z-axis/Userzcoor").gameObject.transform.position;
                GameObject.Find("ImageTarget/ref2/x-axis/Cylinder").gameObject.GetComponent<Renderer>().material.color = new Color(255, 0, 0, 0.3f);
                GameObject.Find("ImageTarget/ref2/y-axis/Cylinder").gameObject.GetComponent<Renderer>().material.color = new Color(0, 255, 0, 0.3f);
                GameObject.Find("ImageTarget/ref2/z-axis/Cylinder").gameObject.GetComponent<Renderer>().material.color = new Color(0, 0, 255, 0.3f);
            }


            User.transform.localRotation = Quaternion.Slerp(User.transform.localRotation, q2, Time.deltaTime / 3);


        }

        if (Buttonid.Step == 3)
        {

            if (Buttonid.Step == 3)
            {
                Timer3 = Timer3 + Time.deltaTime;
                if (Timer3 <= 8)
                {
                    Number.text = (8 - Timer3).ToString("f1");
                }
                Clock.GetComponent<Image>().fillAmount = 1 - Timer3 / 8;

                if (Iscreated3)
                {
                    if (GameObject.Find("ref2"))
                    {
                        Destroy(GameObject.Find("ref2"));
                    }
                    if (GameObject.Find("ansref2"))
                    {
                        Destroy(GameObject.Find("ansref2"));
                    }
                    var clone1 = Instantiate(User, imagetarget);
                    clone1.name = "ref3";
                    Iscreated3 = false;


                }

                Quaternion lastRotation = Cam.rotation;

                UserxRef.transform.rotation = lastRotation;
                UseryRef.transform.rotation = lastRotation;
                UserzRef.transform.rotation = lastRotation;


                if (GameObject.Find("ImageTarget/ref3") == true)
                {
                    UserxRef.transform.position = GameObject.Find("ImageTarget/ref3/x-axis/Userxcoor").gameObject.transform.position;
                    UseryRef.transform.position = GameObject.Find("ImageTarget/ref3/y-axis/Userycoor").gameObject.transform.position;
                    UserzRef.transform.position = GameObject.Find("ImageTarget/ref3/z-axis/Userzcoor").gameObject.transform.position;
                    GameObject.Find("ImageTarget/ref3/x-axis/Cylinder").gameObject.GetComponent<Renderer>().material.color = new Color(255, 0, 0, 0.3f);
                    GameObject.Find("ImageTarget/ref3/y-axis/Cylinder").gameObject.GetComponent<Renderer>().material.color = new Color(0, 255, 0, 0.3f);
                    GameObject.Find("ImageTarget/ref3/z-axis/Cylinder").gameObject.GetComponent<Renderer>().material.color = new Color(0, 0, 255, 0.3f);
                }




                User.transform.localRotation = Quaternion.Slerp(User.transform.localRotation, q3, Time.deltaTime / 3);

            }

        }




    }

}