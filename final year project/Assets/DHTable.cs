using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DHTable : MonoBehaviour
{
    public int Selected_Index;
    public int Answer;
    public string Selected_axis;

    public GameObject[] DH_Table_Element;
    public Material Correct_Material;
    public Material Wrong_Material;

    public string answerA = "";
    public string answerB = "";

    private string[,] solution = 
        { {"f0x" , "f0z"} , {"f0z" , "f1z"} , {"f0x" , "f1x"} , {"f0z" , ""} , {"f0z" , ""} , {"f0z" , ""} , {"f0z" , ""} , {"f0z" , ""} , {"f0z" , ""} , {"f0z" , ""} , {"f0z" , ""} , {"f0z" , ""} , {"f0z" , ""} , {"f0z" , ""} , {"f0z" , ""} , {"f0z" , ""} };

    public void DHTable_btn(int answer)
    {
        Answer = answer;
    }

    private void Update()
    {
        answerA = solution[Answer, 0];
        answerB = solution[Answer, 1];

        RaycastHit hit;

        //if (Input.GetMouseButtonDown(0))
        //{
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit))
            {

                if (hit.collider.gameObject.tag == "Axis")
                {
                    Selected_axis = hit.collider.gameObject.name;
                }

            }

            if (Selected_axis == answerA)
            {
                if (Selected_axis == answerB)
                {
                    DH_Table_Element[Answer].GetComponent<Image>().color = Color.green;
                }
                else if (Selected_axis == answerB)
                {
                    if (Selected_axis == answerA)
                    {
                        DH_Table_Element[Answer].GetComponent<Image>().color = Color.green;
                    }
                }
                else
                {
                    DH_Table_Element[Answer].GetComponent<Image>().color = Color.red;
                }
            }


        //}


    }
}
