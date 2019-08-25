using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class MoveObject_Matrix : MonoBehaviour {

    public Transform Cam;
    public GameObject UserxRef;
    public GameObject UseryRef;
    public GameObject UserzRef;
    public GameObject Ans;
    public GameObject User;
  
    public GameObject AnsxRef;
    public GameObject AnsyRef;
    public GameObject AnszRef;

    
    public GameObject Step2;
    public GameObject Step3;

    Quaternion q1;
    Vector3 v1;
    Quaternion q2;
    Vector3 v2;
    Quaternion q3;
    Vector3 v3;
    Quaternion q4;
    Vector3 v4;

    Quaternion q1_ans;
    Quaternion q2_ans;
    Quaternion q3_ans;
    Quaternion q4_ans;

    const float r = 40;
    public static Vector3  Newposition1= new Vector3(0, 0.2f, -0.3f);
    public static Vector3 Newposition2= new Vector3(0, 0.2f, -0.3f);
    public static Vector3 Newposition3= new Vector3(0, 0.2f, -0.3f);
    public static Vector3 Newposition4= new Vector3(0, 0.2f, -0.3f);
    public CanvasGroup submitbutton;
    
    public Transform imagetarget;
    public static bool Iscreated1 = true;
    public static bool Iscreated2 = true;
    public static bool Iscreated3 = true;


    public static float Timer1 = 0;
    public static float Timer2 = 0;

    public GameObject Correct;
    public GameObject Wrong;

    public void Onclick()
    {
        
        if (Submit.NumofMatrix == 1)
        {
            q1 = Transformation_Matrix.GetRotation(Submit.Usermat1);
            v1 = Transformation_Matrix.GetPostion(Submit.Usermat1)/r ; 
            q1_ans = Transformation_Matrix.GetRotation(Submit.Ans1);

            Newposition1 = Newposition1 + v1;
          
            
        }
        if (Submit.NumofMatrix == 2)
        {
            q1= Transformation_Matrix.GetRotation(Submit.Usermat1);
            v1 = Transformation_Matrix.GetPostion(Submit.Usermat1 )/r;
            q1_ans = Transformation_Matrix.GetRotation(Submit.Ans1);

            q2 = Transformation_Matrix.GetRotation(Submit.Usermat1 * Submit.Usermat2);
            v2 = Transformation_Matrix.GetPostion(Submit.Usermat1 * Submit.Usermat2) / r;
            q2_ans = Transformation_Matrix.GetRotation(Submit.Ans1 * Submit.Ans2);

            Newposition1 = Newposition1 + v1;
            Newposition2 = Newposition2 + v2;
            

        }
        if (Submit.NumofMatrix == 3)
        {
            q1 = Transformation_Matrix.GetRotation(Submit.Usermat1);
            v1 = Transformation_Matrix.GetPostion(Submit.Usermat1) / r;
            q1_ans = Transformation_Matrix.GetRotation(Submit.Ans1);

            q2 = Transformation_Matrix.GetRotation(Submit.Usermat1 * Submit.Usermat2);
            v2 = Transformation_Matrix.GetPostion(Submit.Usermat1 * Submit.Usermat2) / r;
            q2_ans = Transformation_Matrix.GetRotation(Submit.Ans1 * Submit.Ans2);

            q3 = Transformation_Matrix.GetRotation(Submit.Usermat1 * Submit.Usermat2 * Submit.Usermat3);
            v3 = Transformation_Matrix.GetPostion(Submit.Usermat1 * Submit.Usermat2 * Submit.Usermat3) / r;
            q3_ans = Transformation_Matrix.GetRotation(Submit.Ans1 * Submit.Ans2 * Submit.Ans3);


            Newposition1 = Newposition1 + v1;
            Newposition2 = Newposition2 + v2;
            Newposition3 = Newposition3 + v3;



        }
        if (Submit.NumofMatrix == 4)
        {
            q1 = Transformation_Matrix.GetRotation(Submit.Usermat1);
            v1 = Transformation_Matrix.GetPostion(Submit.Usermat1) / r;
            q1_ans = Transformation_Matrix.GetRotation(Submit.Ans1);

            q2 = Transformation_Matrix.GetRotation(Submit.Usermat1 * Submit.Usermat2);
            v2 = Transformation_Matrix.GetPostion(Submit.Usermat1 * Submit.Usermat2) / r;
            q2_ans = Transformation_Matrix.GetRotation(Submit.Ans1 * Submit.Ans2);

            q3 = Transformation_Matrix.GetRotation(Submit.Usermat1 * Submit.Usermat2 * Submit.Usermat3);
            v3 = Transformation_Matrix.GetPostion(Submit.Usermat1 * Submit.Usermat2 * Submit.Usermat3) / r;
            q3_ans = Transformation_Matrix.GetRotation(Submit.Ans1 * Submit.Ans2 * Submit.Ans3);

            q4 = Transformation_Matrix.GetRotation(Submit.Usermat1 * Submit.Usermat2 * Submit.Usermat3 * Submit.Usermat4);
            v4 = Transformation_Matrix.GetPostion(Submit.Usermat1 * Submit.Usermat2 * Submit.Usermat3 * Submit.Usermat4) / r;
            q4_ans = Transformation_Matrix.GetRotation(Submit.Ans1 * Submit.Ans2 * Submit.Ans3 * Submit.Ans4);

            Newposition1 = Newposition1 + v1;
            Newposition2 = Newposition2 + v2;
            Newposition3 = Newposition3 + v3;
            Newposition4 = Newposition4 + v4;
        }

    }


     void FixedUpdate()
    {
        
      
        if (Timer1>8)
        {
            Step2.SetActive(true);
        }
        if(Timer2>8)
        {
            Step3.SetActive(true);
        }
        

        if (Submit.NumofMatrix == 1)
            if (Buttonid.Step == 1)
            {
                {
                    
                    User.transform.localPosition = Vector3.Lerp(User.transform.localPosition, Newposition1, Time.deltaTime / 3);
                    User.transform.localRotation = Quaternion.Slerp(User.transform.localRotation, q1, Time.deltaTime / 3);
                }
            }


        if (Submit.NumofMatrix == 2)
        {
                if (Buttonid.Step==1)
                {
                    User.transform.localPosition = Vector3.Lerp(User.transform.localPosition, Newposition1, Time.deltaTime / 3);
                    User.transform.localRotation = Quaternion.Slerp(User.transform.localRotation, q1, Time.deltaTime / 3);
                }

                if(Buttonid.Step==2)
                {
                     User.transform.localPosition = Vector3.Lerp(User.transform.localPosition, Newposition2, Time.deltaTime / 3);
                     User.transform.localRotation = Quaternion.Slerp(User.transform.localRotation, q2, Time.deltaTime / 3);
                }
          }

        if (Submit.NumofMatrix == 3)
        {
          
                if (Buttonid.Step == 1)
                {
                    Timer1 = Timer1 + Time.deltaTime;
                    if (Iscreated1)
                    {
                       Iscreated1 =false;
                        var clone1=Instantiate(User, imagetarget) ;
                       
                        clone1.name = "ref1";
                       

                        var clone2 = Instantiate(Ans, imagetarget);
                        clone2.name = "ansref1";
                    
                    }
               Quaternion lastRotation = Cam.rotation;
                
                UserxRef.transform.rotation = lastRotation;
                UseryRef.transform.rotation = lastRotation;
                UserzRef.transform.rotation = lastRotation;
                AnsxRef.transform.rotation = lastRotation;
                AnsyRef.transform.rotation = lastRotation;
                AnszRef.transform.rotation = lastRotation;


                if (GameObject.Find("ImageTarget/ref1") == true)
                {
                    UserxRef.transform.position = GameObject.Find("ImageTarget/ref1/x-axis/Userxcoor").gameObject.transform.position;
                   UseryRef.transform.position = GameObject.Find("ImageTarget/ref1/y-axis/Userycoor").gameObject.transform.position;
                    UserzRef.transform.position = GameObject.Find("ImageTarget/ref1/z-axis/Userzcoor").gameObject.transform.position;
                    GameObject.Find("ImageTarget/ref1/x-axis/Cylinder").gameObject.GetComponent<Renderer>().material.color = new Color(255, 0, 0, 0.3f);
                    GameObject.Find("ImageTarget/ref1/y-axis/Cylinder").gameObject.GetComponent<Renderer>().material.color = new Color(0, 255, 0, 0.3f);
                    GameObject.Find("ImageTarget/ref1/z-axis/Cylinder").gameObject.GetComponent<Renderer>().material.color = new Color(0, 0, 255, 0.3f);

                }

                if (GameObject.Find("ImageTarget/ansref1") == true)
                {
                   AnsxRef.transform.position = GameObject.Find("ImageTarget/ansref1/x-axis/Ansxcoor").gameObject.transform.position;
                   AnsyRef.transform.position = GameObject.Find("ImageTarget/ansref1/y-axis/Ansycoor").gameObject.transform.position;
                   AnszRef.transform.position = GameObject.Find("ImageTarget/ansref1/z-axis/Anszcoor").gameObject.transform.position;
                    GameObject.Find("ImageTarget/ansref1/x-axis/Cylinder").gameObject.GetComponent<Renderer>().material.color = new Color(255, 0, 0, 0.3f);
                    GameObject.Find("ImageTarget/ansref1/y-axis/Cylinder").gameObject.GetComponent<Renderer>().material.color = new Color(0, 255, 0, 0.3f);
                    GameObject.Find("ImageTarget/ansref1/z-axis/Cylinder").gameObject.GetComponent<Renderer>().material.color = new Color(0, 0, 255, 0.3f);

                }

                User.transform.localPosition = Vector3.Lerp(User.transform.localPosition, Newposition1, Time.deltaTime / 3);
                    User.transform.localRotation = Quaternion.Slerp(User.transform.localRotation, q1, Time.deltaTime / 3);

                
                    Ans.transform.localRotation = Quaternion.Slerp(Ans.transform.localRotation, q1_ans, Time.deltaTime / 3);
                
                }

                if (Buttonid.Step == 2)
                {
                Timer2 = Timer2 + Time.deltaTime;
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
                        var clone1=Instantiate(User, imagetarget);
                        clone1.name = "ref2";
                     Iscreated2 = false;

                        var clone2 = Instantiate(Ans, imagetarget);
                        clone2.name = "ansref2";
                    }
                Quaternion lastRotation = Cam.rotation;

                UserxRef.transform.rotation = lastRotation;
                UseryRef.transform.rotation = lastRotation;
                UserzRef.transform.rotation = lastRotation;
                AnsxRef.transform.rotation = lastRotation;
                AnsyRef.transform.rotation = lastRotation;
                AnszRef.transform.rotation = lastRotation;

                if (GameObject.Find("ImageTarget/ref2") == true)
                {
                    UserxRef.transform.position = GameObject.Find("ImageTarget/ref2/x-axis/Userxcoor").gameObject.transform.position;
                    UseryRef.transform.position = GameObject.Find("ImageTarget/ref2/y-axis/Userycoor").gameObject.transform.position;
                    UserzRef.transform.position = GameObject.Find("ImageTarget/ref2/z-axis/Userzcoor").gameObject.transform.position;
                    GameObject.Find("ImageTarget/ref2/x-axis/Cylinder").gameObject.GetComponent<Renderer>().material.color = new Color(255, 0, 0, 0.3f);
                    GameObject.Find("ImageTarget/ref2/y-axis/Cylinder").gameObject.GetComponent<Renderer>().material.color = new Color(0, 255, 0, 0.3f);
                    GameObject.Find("ImageTarget/ref2/z-axis/Cylinder").gameObject.GetComponent<Renderer>().material.color = new Color(0, 0, 255, 0.3f);
                }

                if (GameObject.Find("ImageTarget/ansref2") == true)
                {
                    AnsxRef.transform.position = GameObject.Find("ImageTarget/ansref2/x-axis/Ansxcoor").gameObject.transform.position;
                    AnsyRef.transform.position = GameObject.Find("ImageTarget/ansref2/y-axis/Ansycoor").gameObject.transform.position;
                    AnszRef.transform.position = GameObject.Find("ImageTarget/ansref2/z-axis/Anszcoor").gameObject.transform.position;
                    GameObject.Find("ImageTarget/ansref2/x-axis/Cylinder").gameObject.GetComponent<Renderer>().material.color = new Color(255, 0, 0, 0.3f);
                    GameObject.Find("ImageTarget/ansref2/y-axis/Cylinder").gameObject.GetComponent<Renderer>().material.color = new Color(0, 255, 0, 0.3f);
                    GameObject.Find("ImageTarget/ansref2/z-axis/Cylinder").gameObject.GetComponent<Renderer>().material.color = new Color(0, 0, 255, 0.3f);
                }
                

                User.transform.localPosition = Vector3.Lerp(User.transform.localPosition, Newposition2, Time.deltaTime / 3);
                    User.transform.localRotation = Quaternion.Slerp(User.transform.localRotation, q2, Time.deltaTime / 3);
                    
                    Ans.transform.localRotation = Quaternion.Slerp(Ans.transform.localRotation, q2_ans, Time.deltaTime / 3);
                }

                if (Buttonid.Step == 3)
                {
                
                if (Iscreated3)
                    {
                        if (GameObject.Find("ref2"))
                        {
                            Destroy( GameObject.Find("ref2"));
                        }
                        if (GameObject.Find("ansref2"))
                        {
                           Destroy(GameObject.Find("ansref2"));
                        }
                        var clone1=Instantiate(User, imagetarget);
                        clone1.name = "ref3";
                        Iscreated3 = false;

                        var clone2 = Instantiate(Ans, imagetarget);
                        clone2.name = "ansref3";

                }
                Quaternion lastRotation = Cam.rotation;

                UserxRef.transform.rotation = lastRotation;
                UseryRef.transform.rotation = lastRotation;
                UserzRef.transform.rotation = lastRotation;
                AnsxRef.transform.rotation = lastRotation;
                AnsyRef.transform.rotation = lastRotation;
                AnszRef.transform.rotation = lastRotation;

                if (GameObject.Find("ImageTarget/ref3") == true)
                {
                    UserxRef.transform.position = GameObject.Find("ImageTarget/ref3/x-axis/Userxcoor").gameObject.transform.position;
                    UseryRef.transform.position = GameObject.Find("ImageTarget/ref3/y-axis/Userycoor").gameObject.transform.position;
                    UserzRef.transform.position = GameObject.Find("ImageTarget/ref3/z-axis/Userzcoor").gameObject.transform.position;
                    GameObject.Find("ImageTarget/ref3/x-axis/Cylinder").gameObject.GetComponent<Renderer>().material.color = new Color(255, 0, 0, 0.3f);
                    GameObject.Find("ImageTarget/ref3/y-axis/Cylinder").gameObject.GetComponent<Renderer>().material.color = new Color(0, 255, 0, 0.3f);
                    GameObject.Find("ImageTarget/ref3/z-axis/Cylinder").gameObject.GetComponent<Renderer>().material.color = new Color(0, 0, 255, 0.3f);
                }

                if (GameObject.Find("ImageTarget/ansref3") == true)
                {
                    AnsxRef.transform.position = GameObject.Find("ImageTarget/ansref3/x-axis/Ansxcoor").gameObject.transform.position;
                    AnsyRef.transform.position = GameObject.Find("ImageTarget/ansref3/y-axis/Ansycoor").gameObject.transform.position;
                    AnszRef.transform.position = GameObject.Find("ImageTarget/ansref3/z-axis/Anszcoor").gameObject.transform.position;
                    GameObject.Find("ImageTarget/ansref3/x-axis/Cylinder").gameObject.GetComponent<Renderer>().material.color = new Color(255, 0, 0, 0.3f);
                    GameObject.Find("ImageTarget/ansref3/y-axis/Cylinder").gameObject.GetComponent<Renderer>().material.color = new Color(0, 255, 0, 0.3f);
                    GameObject.Find("ImageTarget/ansref3/z-axis/Cylinder").gameObject.GetComponent<Renderer>().material.color = new Color(0, 0, 255, 0.3f);
                    
                }

                User.transform.localPosition = Vector3.Lerp(User.transform.localPosition, Newposition3, Time.deltaTime / 3);
                    User.transform.localRotation = Quaternion.Slerp(User.transform.localRotation, q3, Time.deltaTime / 3);
                    
                    Ans.transform.localRotation = Quaternion.Slerp(Ans.transform.localRotation, q3_ans, Time.deltaTime / 3);
                }
           
        }


        if (Submit.NumofMatrix == 4)
        {
            if (Buttonid.Step == 1)
            {
                User.transform.localPosition = Vector3.Lerp(User.transform.localPosition, Newposition1, Time.deltaTime / 3);
                User.transform.localRotation = Quaternion.Slerp(User.transform.localRotation, q1, Time.deltaTime / 3);
            }

            if (Buttonid.Step == 2)
            {
                User.transform.localPosition = Vector3.Lerp(User.transform.localPosition, Newposition2, Time.deltaTime / 3);
                User.transform.localRotation = Quaternion.Slerp(User.transform.localRotation, q2, Time.deltaTime / 3);
            }

            if (Buttonid.Step == 3)
            {
                User.transform.localPosition = Vector3.Lerp(User.transform.localPosition, Newposition3, Time.deltaTime / 3);
                User.transform.localRotation = Quaternion.Slerp(User.transform.localRotation, q3, Time.deltaTime / 3);
            }

            if (Buttonid.Step == 4)
            {
                User.transform.localPosition = Vector3.Lerp(User.transform.localPosition, Newposition4, Time.deltaTime / 3);
                User.transform.localRotation = Quaternion.Slerp(User.transform.localRotation, q4, Time.deltaTime / 3);
                
            }
        }




    }

    public void Hide()
    {
        submitbutton.alpha = 0.0f;
    }

    public void WrongorCorrect()
    {
        Correct.SetActive(false);
        Wrong.SetActive(false);
    }
    

}

