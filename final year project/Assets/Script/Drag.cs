using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drag : MonoBehaviour
{
    public bool active;
    public string rotate_dir;
    public string axis;
    public float move_factor;
    public bool initial_flag = false;
    public string model_index;
    public float rotation_factor = 0.1f;
    public float translation_factor = 1f;
    public float rotationspeed = 10;
    public bool change_done = false;
    public Material y_highlight_material;
    public Material x_highlight_material;
    public Material z_highlight_material;
    public Material x;
    public Material y;
    public Material z;

    public bool micro_editing = false;
    private Vector3 origin_mouse_pos;
    private Vector3 origin_pos;
    private double moving_distance;
    private float distance = 100;

    private GameObject selected_model;
    private float difference;
    private Vector3 selected_model_translation;
    private Vector3 selected_model_rotation;
    private Vector3 translation_change;
    private Vector3 rotation_change;
    public float slider_value;
    public float previous_slider_value = 0;
    public float slider_change_value;

    private void Update()
    {
        if (active)
        {
            if (micro_editing)
            {
                translation_factor = 0.1f;
                rotation_factor = 0.01f;
            }
            else
            {
                translation_factor = 1f;
                rotation_factor = 0.1f;
            }

            slider_value = GameObject.Find("Canvas").GetComponent<Spawner>().slider_value;

            selected_model = GameObject.Find(model_index);

            selected_model_translation = GameObject.Find(model_index).GetComponent<GeoData>().Translation;
            selected_model_rotation = GameObject.Find(model_index).GetComponent<GeoData>().Rotation;
            //selected_model_translation = GameObject.Find("Canvas").GetComponent<Spawner>().model_translation.ElementAt((int)Convert.ToInt16(model_index));
            //selected_model_rotation = GameObject.Find("Canvas").GetComponent<Spawner>().model_rotation.ElementAt((int)Convert.ToInt16(model_index));

            if (change_done)
            {
                previous_slider_value = 0;
                slider_value = 0;
                slider_change_value = 0;
            }
            else if (!change_done)
            {
                slider_change_value = slider_value - previous_slider_value;
            }
            
            //Debug.Log(slider_change_value);
            //Debug.Log(axis);
            if (axis == "X-axis")
            {
                selected_model.transform.GetChild(0).GetChild(0).GetChild(1).GetComponent<Renderer>().material = y;
                selected_model.transform.GetChild(0).GetChild(0).GetChild(2).GetComponent<Renderer>().material = y;
                selected_model.transform.GetChild(0).GetChild(1).GetChild(1).GetComponent<Renderer>().material = z;
                selected_model.transform.GetChild(0).GetChild(1).GetChild(2).GetComponent<Renderer>().material = z;
                selected_model.transform.GetChild(0).GetChild(2).GetChild(1).GetComponent<Renderer>().material = x_highlight_material;
                selected_model.transform.GetChild(0).GetChild(1).GetChild(2).GetComponent<Renderer>().material = x_highlight_material;
                selected_model_translation.y += slider_change_value * translation_factor;
                //selected_model.transform.Translate(Vector3.right * Time.deltaTime , Space.Self);
                translation_change = new Vector3(0f, slider_change_value * translation_factor, 0f);
            }
            else if (axis == "Y-axis")
            {
                selected_model.transform.GetChild(0).GetChild(0).GetChild(1).GetComponent<Renderer>().material = y_highlight_material;
                selected_model.transform.GetChild(0).GetChild(0).GetChild(2).GetComponent<Renderer>().material = y_highlight_material;
                selected_model.transform.GetChild(0).GetChild(1).GetChild(1).GetComponent<Renderer>().material = z;
                selected_model.transform.GetChild(0).GetChild(1).GetChild(2).GetComponent<Renderer>().material = z;
                selected_model.transform.GetChild(0).GetChild(2).GetChild(1).GetComponent<Renderer>().material = x;
                selected_model.transform.GetChild(0).GetChild(1).GetChild(2).GetComponent<Renderer>().material = x;
                selected_model_translation.z += slider_change_value * translation_factor;
                //selected_model.transform.Translate(Vector3.up * Time.deltaTime , Space.Self);
                translation_change = new Vector3(0f, 0f, slider_change_value * translation_factor);
            }
            else if (axis == "Z-axis")
            {
                selected_model.transform.GetChild(0).GetChild(0).GetChild(1).GetComponent<Renderer>().material = y;
                selected_model.transform.GetChild(0).GetChild(0).GetChild(2).GetComponent<Renderer>().material = y;
                selected_model.transform.GetChild(0).GetChild(1).GetChild(1).GetComponent<Renderer>().material = z_highlight_material;
                selected_model.transform.GetChild(0).GetChild(1).GetChild(2).GetComponent<Renderer>().material = z_highlight_material;
                selected_model.transform.GetChild(0).GetChild(2).GetChild(1).GetComponent<Renderer>().material = x;
                selected_model.transform.GetChild(0).GetChild(1).GetChild(2).GetComponent<Renderer>().material = x;
                selected_model_translation.x += slider_change_value * translation_factor;
                //selected_model.transform.Translate( selected_model_translation.x, Space.Self);
                translation_change = new Vector3(slider_change_value * translation_factor, 0f, 0f);
            }
            else
            {
                selected_model.transform.GetChild(0).GetChild(0).GetChild(1).GetComponent<Renderer>().material = y;
                selected_model.transform.GetChild(0).GetChild(0).GetChild(2).GetComponent<Renderer>().material = y;
                selected_model.transform.GetChild(0).GetChild(1).GetChild(1).GetComponent<Renderer>().material = z;
                selected_model.transform.GetChild(0).GetChild(1).GetChild(2).GetComponent<Renderer>().material = z;
                selected_model.transform.GetChild(0).GetChild(2).GetChild(1).GetComponent<Renderer>().material = x;
                selected_model.transform.GetChild(0).GetChild(1).GetChild(2).GetComponent<Renderer>().material = x;
            }
            selected_model.transform.Translate(translation_change, Space.Self);

            Quaternion Rot_origin = Quaternion.Euler(selected_model_rotation.x, selected_model_rotation.y, selected_model_rotation.z);
            Debug.Log(rotate_dir);

            if (rotate_dir == "Pitch")
            {
                selected_model.transform.GetChild(1).GetChild(2).GetComponent<Renderer>().material = y_highlight_material;
                selected_model.transform.GetChild(1).GetChild(1).GetComponent<Renderer>().material = z;
                selected_model.transform.GetChild(1).GetChild(3).GetComponent<Renderer>().material = x;
                selected_model_rotation.z += slider_change_value * rotation_factor;
                rotation_change = new Vector3(0f, 0f, slider_change_value * rotation_factor);
            }
            else if (rotate_dir == "Yaw")
            {
                selected_model.transform.GetChild(1).GetChild(1).GetComponent<Renderer>().material = z_highlight_material;
                selected_model.transform.GetChild(1).GetChild(2).GetComponent<Renderer>().material = y;
                selected_model.transform.GetChild(1).GetChild(3).GetComponent<Renderer>().material = x;
                selected_model_rotation.x += slider_change_value * rotation_factor;
                rotation_change = new Vector3(slider_change_value * rotation_factor, 0f, 0f);
            }
            else if (rotate_dir == "Roll")
            {
                selected_model.transform.GetChild(1).GetChild(3).GetComponent<Renderer>().material = x_highlight_material;
                selected_model.transform.GetChild(1).GetChild(2).GetComponent<Renderer>().material = y;
                selected_model.transform.GetChild(1).GetChild(1).GetComponent<Renderer>().material = z;
                selected_model_rotation.y += slider_change_value * rotation_factor;
                rotation_change = new Vector3(0f, slider_change_value * rotation_factor, 0f);
            }
            else
            {
                selected_model.transform.GetChild(1).GetChild(2).GetComponent<Renderer>().material = y;
                selected_model.transform.GetChild(1).GetChild(1).GetComponent<Renderer>().material = z;
                selected_model.transform.GetChild(1).GetChild(3).GetComponent<Renderer>().material = x;
            }
            //Quaternion Rot_destination = Quaternion.Euler(selected_model_rotation.x, selected_model_rotation.y, selected_model_rotation.z);
            //selected_model.transform.rotation = Quaternion.Lerp(Rot_origin, Rot_destination, rotationspeed);
            selected_model.transform.Rotate(rotation_change, Space.Self);

            GameObject.Find(model_index).GetComponent<GeoData>().Translation = selected_model_translation;
            GameObject.Find(model_index).GetComponent<GeoData>().Rotation = selected_model_rotation;

            if (!change_done)
            {
                previous_slider_value = slider_value;
            }
            
        }
    }


}

