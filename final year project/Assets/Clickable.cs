using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clickable : MonoBehaviour
{
    public string coord_or_rotate;
    public Material transparent;
    public Material default_material;
    private GameObject current_target;
    private GameObject previous_target;

    private GameObject coord_target;
    private GameObject rotate_target;
    // Update is called once per frame

    private int child_index = 0;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            coord_or_rotate = GameObject.Find("Canvas").GetComponent<Spawner>().coord_or_rotate;

            if (coord_or_rotate == "coordinate")
            {
                if (child_index == 1)
                {
                    current_target.gameObject.transform.GetChild(child_index).gameObject.SetActive(false);

                }

                if (rotate_target != null)
                {
                    //rotate_target.transform.parent.parent.GetComponent<Drag>().rotate_dir = " ";
                    GameObject.Find("Canvas").GetComponent<Drag>().rotate_dir = "";
                }

                child_index = 0;
            }
            else if (coord_or_rotate == "rotation")
            {
                if (child_index == 0 && current_target != null)
                {
                    current_target.gameObject.transform.GetChild(child_index).gameObject.SetActive(false);

                }

                if (coord_target != null)
                {
                    //coord_target.transform.parent.parent.GetComponent<Drag>().axis = " ";
                    GameObject.Find("Canvas").GetComponent<Drag>().axis = "";
                }
                child_index = 1;
            }


            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider.gameObject.tag == "Model")
                {

                    current_target = hit.collider.gameObject;
                    current_target.gameObject.transform.GetChild(child_index).gameObject.SetActive(true);
                    current_target.GetComponent<Renderer>().material = transparent;
                    if (previous_target != null && previous_target != current_target)
                    {
                        previous_target.gameObject.transform.GetChild(child_index).gameObject.SetActive(false);
                        previous_target.GetComponent<Renderer>().material = default_material;
                    }
                    GameObject.Find("Canvas").GetComponent<Drag>().model_index = current_target.name;
                }

                if (hit.collider.gameObject.tag == "Axis")
                {
                    GameObject.Find("Canvas").GetComponent<Drag>().rotate_dir = "";
                    coord_target = hit.collider.gameObject;
                    GameObject.Find("Canvas").GetComponent<Drag>().active = true;
                    GameObject.Find("Canvas").GetComponent<Drag>().axis = coord_target.transform.GetChild(1).gameObject.tag.ToString();
                    GameObject.Find("Canvas").GetComponent<Drag>().initial_flag = true;
                    //coord_target.transform.parent.parent.GetComponent<Drag>().model_index = coord_target.transform.parent.parent.name;
                }

                //if (hit.collider.gameObject.transform.parent.gameObject.tag == "Rotation") // shows error for no reason
                if (hit.collider.gameObject.tag == "Yaw" || hit.collider.gameObject.tag == "Roll" || hit.collider.gameObject.tag == "Pitch")
                {
                    GameObject.Find("Canvas").GetComponent<Drag>().axis = "";
                    rotate_target = hit.collider.gameObject;
                    GameObject.Find("Canvas").GetComponent<Drag>().active = true;
                    GameObject.Find("Canvas").GetComponent<Drag>().rotate_dir = rotate_target.transform.tag.ToString();
                    GameObject.Find("Canvas").GetComponent<Drag>().initial_flag = true;
                    //rotate_target.transform.parent.parent.GetComponent<Drag>().model_index = rotate_target.transform.parent.parent.name;
                }
            }


            previous_target = current_target;
        }
    }
}
