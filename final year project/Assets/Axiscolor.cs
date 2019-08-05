using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Axiscolor : MonoBehaviour
{
    public GameObject xx;
    public GameObject yy;
    public GameObject zz;
    void Start()
    {

        xx.GetComponent<MeshRenderer>().material.color = Color.red;
        yy.GetComponent<MeshRenderer>().material.color = Color.green;
        zz.GetComponent<MeshRenderer>().material.color = Color.blue;
    }


}
