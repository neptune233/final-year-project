using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class MoveObject_Matrix : MonoBehaviour {

    public Transform Cam;
    public GameObject UserxRef;
    public GameObject UseryRef;
    public GameObject UserzRef;
    public GameObject ans;
    public GameObject cube;
    public GameObject ref1;
    public GameObject ref2;
    public GameObject ref3;
    public GameObject ref4;
   

    Quaternion q1;
    Vector3 v1;
    Quaternion q2;
    Vector3 v2;
    Quaternion q3;
    Vector3 v3;
    Quaternion q4;
    Vector3 v4;
    const float r = 40;
    public static Vector3  Newposition1= new Vector3(0, 0.2f, -0.3f);
    public static Vector3 Newposition2= new Vector3(0, 0.2f, -0.3f);
    public static Vector3 Newposition3= new Vector3(0, 0.2f, -0.3f);
    public static Vector3 Newposition4= new Vector3(0, 0.2f, -0.3f);
    public CanvasGroup submitbutton;
    public int i = 1;
    public Transform imagetarget;



    public void Onclick()
    {
        
        if (Submit.NumofMatrix == 1)
        {
            q1 = Transformation_Matrix.GetRotation(Submit.Output1);
            v1 = Transformation_Matrix.GetPostion(Submit.Output1)/r ; 
            
            Newposition1 = Newposition1 + v1;
          
            
        }
        if (Submit.NumofMatrix == 2)
        {
            q1= Transformation_Matrix.GetRotation(Submit.Output1);
            v1 = Transformation_Matrix.GetPostion(Submit.Output1 )/r;

            q2 = Transformation_Matrix.GetRotation(Submit.Output1 * Submit.Output2);
            v2 = Transformation_Matrix.GetPostion(Submit.Output1 * Submit.Output2) / r;

            Newposition1 = Newposition1 + v1;
            Newposition2 = Newposition2 + v2;
            

        }
        if (Submit.NumofMatrix == 3)
        {
            q1 = Transformation_Matrix.GetRotation(Submit.Output1);
            v1 = Transformation_Matrix.GetPostion(Submit.Output1) / r;

            q2 = Transformation_Matrix.GetRotation(Submit.Output1 * Submit.Output2);
            v2 = Transformation_Matrix.GetPostion(Submit.Output1 * Submit.Output2) / r;

            q3 = Transformation_Matrix.GetRotation(Submit.Output1 * Submit.Output2 * Submit.Output3);
            v3 = Transformation_Matrix.GetPostion(Submit.Output1 * Submit.Output2 * Submit.Output3) / r;

            Debug.Log("q1=" + q1);
            Debug.Log("v1=" + v1);
            Debug.Log("q2=" + q2);
            Debug.Log("v2=" + v2);
            Debug.Log("q3=" + q3);
            Debug.Log("v3=" + v3);

            Newposition1 = Newposition1 + v1;
            Newposition2 = Newposition2 + v2;
            Newposition3 = Newposition3 + v3;



        }
        if (Submit.NumofMatrix == 4)
        {
            q1 = Transformation_Matrix.GetRotation(Submit.Output1);
            v1 = Transformation_Matrix.GetPostion(Submit.Output1) / r;

            q2 = Transformation_Matrix.GetRotation(Submit.Output1 * Submit.Output2);
            v2 = Transformation_Matrix.GetPostion(Submit.Output1 * Submit.Output2) / r;

            q3 = Transformation_Matrix.GetRotation(Submit.Output1 * Submit.Output2 * Submit.Output3);
            v3 = Transformation_Matrix.GetPostion(Submit.Output1 * Submit.Output2 * Submit.Output3) / r;

            q4 = Transformation_Matrix.GetRotation(Submit.Output1 * Submit.Output2 * Submit.Output3 * Submit.Output4);
            v4 = Transformation_Matrix.GetPostion(Submit.Output1 * Submit.Output2 * Submit.Output3 * Submit.Output4) / r;

            Newposition1 = Newposition1 + v1;
            Newposition2 = Newposition2 + v2;
            Newposition3 = Newposition3 + v3;
            Newposition4 = Newposition4 + v4;
        }

    }


     void FixedUpdate()
    {

        if (Submit.NumofMatrix == 1)
            if (Buttonid.Step == 1)
            {
                {
                    Debug.Log(Newposition1);
                    cube.transform.localPosition = Vector3.Lerp(cube.transform.localPosition, Newposition1, Time.deltaTime / 3);
                    cube.transform.localRotation = Quaternion.Slerp(cube.transform.localRotation, q1, Time.deltaTime / 3);
                }
            }


        if (Submit.NumofMatrix == 2)
        {
                if (Buttonid.Step==1)
                {
                    cube.transform.localPosition = Vector3.Lerp(cube.transform.localPosition, Newposition1, Time.deltaTime / 3);
                    cube.transform.localRotation = Quaternion.Slerp(cube.transform.localRotation, q1, Time.deltaTime / 3);
                }

                if(Buttonid.Step==2)
                {
                     cube.transform.localPosition = Vector3.Lerp(cube.transform.localPosition, Newposition2, Time.deltaTime / 3);
                     cube.transform.localRotation = Quaternion.Slerp(cube.transform.localRotation, q2, Time.deltaTime / 3);
                }
          }

        if (Submit.NumofMatrix == 3)
        {
            
                if (Buttonid.Step == 1)
                {
                    ref1.SetActive(true);
                    ref2.SetActive(false);
                    ref3.SetActive(false);
                    ref4.SetActive(false);
                    if (i == 1)
                    {
                        var clone=Instantiate(cube, imagetarget);
                        clone.name = "ref1";
                        i = i + 1;
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
                }


                cube.transform.localPosition = Vector3.Lerp(cube.transform.localPosition, Newposition1, Time.deltaTime / 3);
                    cube.transform.localRotation = Quaternion.Slerp(cube.transform.localRotation, q1, Time.deltaTime / 3);
                    Quaternion step1 = new Quaternion(0, 0.2588f, 0, 0.9659f);
                    ans.transform.localRotation = Quaternion.Slerp(ans.transform.localRotation, step1, Time.deltaTime / 3);
                
                }

                if (Buttonid.Step == 2)
                {
                    ref1.SetActive(false);
                    ref2.SetActive(true);
                    ref3.SetActive(false);
                    ref4.SetActive(false);
                
                   
                    if (i == 2)
                    {
                        GameObject.Find("ref1").SetActive(false);
                        var clone=Instantiate(cube, imagetarget);
                        clone.name = "ref2";
                        i = i + 1;
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
                }

                cube.transform.localPosition = Vector3.Lerp(cube.transform.localPosition, Newposition2, Time.deltaTime / 3);
                    cube.transform.localRotation = Quaternion.Slerp(cube.transform.localRotation, q2, Time.deltaTime / 3);
                    Quaternion step1 = new Quaternion(0.3696f, 0.2391f, -0.1f, 0.8924f);
                    ans.transform.localRotation = Quaternion.Slerp(ans.transform.localRotation, step1, Time.deltaTime / 3);
                }

                if (Buttonid.Step == 3)
                {
                    ref1.SetActive(false);
                    ref2.SetActive(false);
                    ref3.SetActive(true);
                    ref4.SetActive(false);
               
                    if (i == 3)
                    {
                        GameObject.Find("ref2").SetActive(false);
                        var clone=Instantiate(cube, imagetarget);
                        clone.name = "ref3";
                        i = i + 1;
                    
                    }
                Quaternion lastRotation = Cam.rotation;

                UserxRef.transform.rotation = lastRotation;
                UseryRef.transform.rotation = lastRotation;
                UserzRef.transform.rotation = lastRotation;
                if (GameObject.Find("ImageTarget/ref1") == true)
                {
                    UserxRef.transform.position = GameObject.Find("ImageTarget/ref3/x-axis/Userxcoor").gameObject.transform.position;
                    UseryRef.transform.position = GameObject.Find("ImageTarget/ref3/y-axis/Userycoor").gameObject.transform.position;
                    UserzRef.transform.position = GameObject.Find("ImageTarget/ref3/z-axis/Userzcoor").gameObject.transform.position;
                }

                cube.transform.localPosition = Vector3.Lerp(cube.transform.localPosition, Newposition3, Time.deltaTime / 3);
                    cube.transform.localRotation = Quaternion.Slerp(cube.transform.localRotation, q3, Time.deltaTime / 3);
                    Quaternion step1 = new Quaternion(0.4396f, 0.0225f, 0.36f, 0.822f);
                    ans.transform.localRotation = Quaternion.Slerp(ans.transform.localRotation, step1, Time.deltaTime / 3);
                }
           
        }


        if (Submit.NumofMatrix == 4)
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

            if (Buttonid.Step == 4)
            {
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

