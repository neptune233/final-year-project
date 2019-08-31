using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Part1_Start : MonoBehaviour
{
   
    void Update()
    {
        if (GameObject.Find("A") == true)
        {
            GameObject.Find("A/x-axis/Cylinder").gameObject.GetComponent<Renderer>().material.color = new Color(255, 0, 0, 0.3f);
            GameObject.Find("A/y-axis/Cylinder").gameObject.GetComponent<Renderer>().material.color = new Color(0, 255, 0, 0.3f);
            GameObject.Find("A/z-axis/Cylinder").gameObject.GetComponent<Renderer>().material.color = new Color(0, 0, 255, 0.3f);
        }
        if (GameObject.Find("B") == true)
        {
            GameObject.Find("B/x-axis/Cylinder").gameObject.GetComponent<Renderer>().material.color = new Color(255, 0, 0, 0.3f);
            GameObject.Find("B/y-axis/Cylinder").gameObject.GetComponent<Renderer>().material.color = new Color(0, 255, 0, 0.3f);
            GameObject.Find("B/z-axis/Cylinder").gameObject.GetComponent<Renderer>().material.color = new Color(0, 0, 255, 0.3f);
        }
        if (GameObject.Find("C") == true)
        {
            GameObject.Find("C/x-axis/Cylinder").gameObject.GetComponent<Renderer>().material.color = new Color(255, 0, 0, 0.3f);
            GameObject.Find("C/y-axis/Cylinder").gameObject.GetComponent<Renderer>().material.color = new Color(0, 255, 0, 0.3f);
            GameObject.Find("Cz-axis/Cylinder").gameObject.GetComponent<Renderer>().material.color = new Color(0, 0, 255, 0.3f);
        }
        if (GameObject.Find("D") == true)
        {
            GameObject.Find("D/x-axis/Cylinder").gameObject.GetComponent<Renderer>().material.color = new Color(255, 0, 0, 0.3f);
            GameObject.Find("D/y-axis/Cylinder").gameObject.GetComponent<Renderer>().material.color = new Color(0, 255, 0, 0.3f);
            GameObject.Find("D/z-axis/Cylinder").gameObject.GetComponent<Renderer>().material.color = new Color(0, 0, 255, 0.3f);
        }
    }

  
}
