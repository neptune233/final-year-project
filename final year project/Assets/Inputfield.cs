using UnityEngine;
using System.Collections;
using UnityEngine.UI; 

public class Inputfield : MonoBehaviour
{
   // public InputField mainInputField;
    public Text position;
    public GameObject cube;
    float a;
    float b;
    float c;
    float x;
    float y;
    float z;
    public GameObject point;
    public GameObject textmesh;
    public Transform origin;


    //function for caculating the relativeposition between two objects
    private Vector3 GetRelativePosition(Transform origin, Vector3 position)
    {
        Vector3 distance = position - origin.position;
        Vector3 relativePosition = Vector3.zero;
        relativePosition.x = Vector3.Dot(distance, origin.right.normalized);
        relativePosition.y = Vector3.Dot(distance, origin.up.normalized);
        relativePosition.z = Vector3.Dot(distance, origin.forward.normalized);
        return relativePosition;
    }


    public void Update()
    {
        a = cube.transform.localPosition.x * 40;
        b = (cube.transform.localPosition.y -0.3f)*40;
        c = cube.transform.localPosition.z * 40;
        x=  GetRelativePosition(origin, point.transform.position).x/20;
        y = GetRelativePosition(origin, point.transform.position).y/20;
        z = GetRelativePosition(origin, point.transform.position).z/20;
       // textmesh.GetComponent<TextMesh>().text= "(" + x.ToString() + "," + y.ToString() + "," + z.ToString() + ")";// show the relative coordinate of object
        //position.text ="("+a.ToString()+","+ b.ToString()+","+ c.ToString()+")";
        
    }

}