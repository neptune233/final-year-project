using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Test : MonoBehaviour
{
    public GameObject test_model1;
    public GameObject test_model2;

    public Slider SliderInstance1;
    public Slider SliderInstance2;
    public Slider SliderInstance3;

    private Vector3 rotation1;
    private Vector3 rotation2;
    private Vector3 rotation3;

    private float previous_joint1_slider_value;
    private float previous_joint2_slider_value;
    private float previous_joint3_slider_value;

    private float joint1_slider_value;
    private float joint2_slider_value;
    private float joint3_slider_value;

    private float joint1_slider_changes;
    private float joint2_slider_changes;
    private float joint3_slider_changes;

    private bool joint1_changes;
    private bool joint2_changes;
    private bool joint3_changes;

    public void Joint1(float new_value)
    {
        if (new_value != (float)0)
        {
            joint1_changes = false;
            joint1_slider_value = new_value;
        }
    }

    public void Joint2(float new_value)
    {
        if (new_value != (float)0)
        {
            joint2_changes = false;
            joint2_slider_value = new_value;
        }
    }

    public void Joint3(float new_value)
    {
        if (new_value != (float)0)
        {
            joint3_changes = false;
            joint3_slider_value = new_value;
        }
    }

    private void Update()
    {
        if (Input.GetMouseButtonUp(0))
        {
            joint1_changes = true;
            joint2_changes = true;
            joint3_changes = true;

            SliderInstance1.value = 0;
            SliderInstance2.value = 0;
            SliderInstance3.value = 0;
        }



        if (joint1_changes)
        {
            previous_joint1_slider_value = 0;
            joint1_slider_value = 0;
            joint1_slider_changes = 0;
        }
        else if (!joint1_changes)
        {
            joint1_slider_changes = joint1_slider_value - previous_joint1_slider_value;
        }

        if (joint2_changes)
        {
            previous_joint2_slider_value = 0;
            joint2_slider_value = 0;
            joint2_slider_changes = 0;
        }
        else if (!joint2_changes)
        {
            joint2_slider_changes = joint2_slider_value - previous_joint2_slider_value;
        }

        if (joint3_changes)
        {
            previous_joint3_slider_value = 0;
            joint3_slider_value = 0;
            joint3_slider_changes = 0;
        }
        else if (!joint3_changes)
        {
            joint3_slider_changes = joint3_slider_value - previous_joint3_slider_value;
        }

        rotation1 = new Vector3(0f, 0f, joint1_slider_changes * 90);
        test_model1.transform.GetChild(0).GetChild(0).Rotate(rotation1, Space.Self); test_model2.transform.GetChild(0).GetChild(0).Rotate(rotation1, Space.Self);

        rotation2 = new Vector3(0f, joint2_slider_changes * 90, 0f);
        test_model1.transform.GetChild(0).GetChild(0).GetChild(0).Rotate(rotation2, Space.Self); test_model2.transform.GetChild(0).GetChild(0).GetChild(0).Rotate(rotation2, Space.Self);

        rotation3 = new Vector3(joint3_slider_changes * 90, 0f, 0f);
        test_model1.transform.GetChild(0).GetChild(0).GetChild(0).GetChild(0).Rotate(rotation3, Space.Self); test_model2.transform.GetChild(0).GetChild(0).GetChild(0).GetChild(0).Rotate(rotation3, Space.Self);

        if (!joint1_changes)
        {
            previous_joint1_slider_value = joint1_slider_value;
        }
        if (!joint2_changes)
        {
            previous_joint2_slider_value = joint2_slider_value;
        }
        if (!joint3_changes)
        {
            previous_joint3_slider_value = joint3_slider_value;
        }
    }
   
    public void Back_btn()
    {
        SceneManager.LoadScene(0);
    }

    //// Update is called once per frame
    //public void Joint1(float changes)
    //{
    //    rotation1 = new Vector3(0f, 0f, changes * 90);
    //    test_model1.transform.GetChild(0).GetChild(0).Rotate(rotation1, Space.Self); test_model2.transform.GetChild(0).GetChild(0).Rotate(rotation1, Space.Self);
    //}

    //public void Joint2(float changes)
    //{
    //    rotation2 = new Vector3(0f, changes * 90, 0f);
    //    test_model1.transform.GetChild(0).GetChild(0).GetChild(0).Rotate(rotation2, Space.Self); test_model2.transform.GetChild(0).GetChild(0).GetChild(0).Rotate(rotation2, Space.Self);
    //}

    //public void Joint3(float changes)
    //{
    //    rotation3 = new Vector3(changes * 90, 0f, 0f);
    //    test_model1.transform.GetChild(0).GetChild(0).GetChild(0).GetChild(0).Rotate(rotation3, Space.Self); test_model2.transform.GetChild(0).GetChild(0).GetChild(0).GetChild(0).Rotate(rotation3, Space.Self);
    //}
}
