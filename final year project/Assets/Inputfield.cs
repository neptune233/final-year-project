using UnityEngine;
using System.Collections;
using UnityEngine.UI; 

public class Inputfield : MonoBehaviour
{
   // public InputField mainInputField;
    public Text position;
    public GameObject cube;
   
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

    private void Start()
    {
        Buttonid.Step = 0;
    }




}