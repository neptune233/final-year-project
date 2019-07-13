using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class MoveObject : MonoBehaviour {
   
    public GameObject cube;
    Quaternion q1;
    Vector3 v1;
    Quaternion q2;
    Vector3 v2;
    Quaternion q3;
    Vector3 v3;
    Quaternion q4;
    Vector3 v4;
    const float r = 40;
    public static Vector3  Newposition1= new Vector3(0, 0.3f, 0);
    public static Vector3 Newposition2= new Vector3(0, 0.3f, 0);
    public static Vector3 Newposition3= new Vector3(0, 0.3f, 0);
    public static Vector3 Newposition4= new Vector3(0, 0.3f, 0);

    public void Start()
    {
        Debug.Log(this.gameObject);
    }




    public void Onclick()
    {
        
        if (Submit.NumofMatrix == 1)
        {
            q1 = Transformation_Matrix.GetRotation(Submit.Output1);
            v1 = Transformation_Matrix.GetPostion(Submit.Output1)/r ; 
            
            Newposition1 = Newposition1 + v1;
            //Debug.Log(Newposition1);
            
        }
        if (Submit.NumofMatrix == 2)
        {
            q1= Transformation_Matrix.GetRotation(Submit.Output1);
            v1 = Transformation_Matrix.GetPostion(Submit.Output1 )/r;

            q2 = Transformation_Matrix.GetRotation(Submit.Output1 * Submit.Output2);
            v2 = Transformation_Matrix.GetPostion(Submit.Output1 * Submit.Output2) / r;

            Newposition1 = Newposition1 + v1;
            Newposition2 = Newposition2 + v2;

            //Debug.Log(Newposition2);

        }
        if (Submit.NumofMatrix == 3)
        {
            q1 = Transformation_Matrix.GetRotation(Submit.Output1);
            v1 = Transformation_Matrix.GetPostion(Submit.Output1) / r;

            q2 = Transformation_Matrix.GetRotation(Submit.Output1 * Submit.Output2);
            v2 = Transformation_Matrix.GetPostion(Submit.Output1 * Submit.Output2) / 20;

            q3 = Transformation_Matrix.GetRotation(Submit.Output1 * Submit.Output2 * Submit.Output3);
            v3 = Transformation_Matrix.GetPostion(Submit.Output1 * Submit.Output2 * Submit.Output3) / 20;

            Debug.Log("choushabi");
            
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
        {
            Debug.Log(Newposition1);
            cube.transform.localPosition = Vector3.Lerp(cube.transform.localPosition, Newposition1, Time.deltaTime/3 );
              cube.transform.localRotation = Quaternion.Slerp(cube.transform.localRotation, q1, Time.deltaTime/3);
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



}

