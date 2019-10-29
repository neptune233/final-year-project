using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sample : MonoBehaviour
{
    public GameObject ref1;
    public GameObject ref2;
    public GameObject ref3;
    public TrailRenderer trail1;
    public TrailRenderer trail2;
    public TrailRenderer trail3;

    public void Step1()
    {
        ref1.SetActive(true);
        ref2.SetActive(false);
        ref3.SetActive(false);
        trail1.Clear();
        trail2.Clear();
        trail3.Clear();
        GameObject.Find("ImageTarget/ref1/x-axis/Cylinder").gameObject.GetComponent<Renderer>().material.color = new Color(255, 0, 0, 0.3f);
        GameObject.Find("ImageTarget/ref1/y-axis/Cylinder").gameObject.GetComponent<Renderer>().material.color = new Color(0, 255, 0, 0.3f);
        GameObject.Find("ImageTarget/ref1/z-axis/Cylinder").gameObject.GetComponent<Renderer>().material.color = new Color(0, 0, 255, 0.3f);
    }

    public void Step2()
    {
        ref1.SetActive(false);
        ref2.SetActive(true);
        ref3.SetActive(false);
        trail1.Clear();
        trail2.Clear();
        trail3.Clear();

        GameObject.Find("ImageTarget/ref2/x-axis/Cylinder").gameObject.GetComponent<Renderer>().material.color = new Color(255, 0, 0, 0.3f);
        GameObject.Find("ImageTarget/ref2/y-axis/Cylinder").gameObject.GetComponent<Renderer>().material.color = new Color(0, 255, 0, 0.3f);
        GameObject.Find("ImageTarget/ref2/z-axis/Cylinder").gameObject.GetComponent<Renderer>().material.color = new Color(0, 0, 255, 0.3f);
    }

    public void Step3()
    {
        ref1.SetActive(false);
        ref2.SetActive(false);
        ref3.SetActive(true);
        trail1.Clear();
        trail2.Clear();
        trail3.Clear();
        GameObject.Find("ImageTarget/ref3/x-axis/Cylinder").gameObject.GetComponent<Renderer>().material.color = new Color(255, 0, 0, 0.3f);
        GameObject.Find("ImageTarget/ref3/y-axis/Cylinder").gameObject.GetComponent<Renderer>().material.color = new Color(0, 255, 0, 0.3f);
        GameObject.Find("ImageTarget/ref3/z-axis/Cylinder").gameObject.GetComponent<Renderer>().material.color = new Color(0, 0, 255, 0.3f);
    }
}
