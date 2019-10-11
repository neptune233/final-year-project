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
    public GameObject Instruction_alpha;
    public GameObject Instruction_a;
    public GameObject Instruction_d;
    public GameObject Instruction_theta;
    public GameObject[] Hint_list;
    public Text Angle;
    public Text Angle_fill1;
    public Text Angle_fill2;
    public Text Distance;
    public Text Distance_fill1;
    public Text Distance_fill2;
    public GameObject Correct_marker;
    public GameObject Wrong_marker;

    public int Instruction_alpha_index = 0;
    public int Instruction_a_index = 0;
    public int Instruction_d_index = 0;
    public int Instruction_theta_index = 0;

    private int Instruction_max = 5;

    public string answerA = "";
    public string answerB = "";

    public string Candidate = "";

    private bool Answer_state = false;
    private GameObject Previous_Axis;
    private int Correct_Stage = 0;

    private bool initial_flag = true;

    private string[,] solution = 
        { {"f0z" , "f1z"} , {"f0z" , "f1z"} , {"f0x" , "f1x"} , {"f0x" , "f1x"} , {"f1z" , "f2z"} , {"f1z" , "f2z"} , {"f1x" , "f2x"} , {"f1x" , "f2x"} , {"f2z" , "f3z"} , {"f2z" , "f3z"} , {"f2x" , "f3x"} , {"f2x" , "f3x"} , {"f3z" , "f4z"} , {"f3z" , "f4z"} , {"f3x" , "f4x"} , {"f3x" , "f4x"} };

    public void start_dh_table_btn()
    {
        if (initial_flag)
        {
            Instruction_alpha_btn();
            initial_flag = false;
        }
    }

    public void Instruction_alpha_btn()
    {
        Instruction_alpha.SetActive(true);
        Instruction_theta.SetActive(false);
        Instruction_d.SetActive(false);
        Instruction_a.SetActive(false);
        

        Instruction_alpha_index = 0;
    }

    public void Instruction_a_btn()
    {
        Instruction_a.SetActive(true);
        Instruction_theta.SetActive(false);
        Instruction_d.SetActive(false);
        
        Instruction_alpha.SetActive(false);

        Instruction_a_index = 0;
    }

    public void Instruction_d_btn()
    {
        Instruction_d.SetActive(true);
        Instruction_theta.SetActive(false);
        
        Instruction_a.SetActive(false);
        Instruction_alpha.SetActive(false);

        Instruction_d_index = 0;
    }

    public void Instruction_theta_btn()
    {
        Instruction_theta.SetActive(true);
        Instruction_d.SetActive(false);
        Instruction_a.SetActive(false);
        Instruction_alpha.SetActive(false);

        Instruction_theta_index = 0;
    }

    public void okay_alpha_btn()
    {
        Instruction_alpha_index += 1;

        if(Instruction_alpha_index > Instruction_max)
        {
            Instruction_alpha_index = Instruction_max;
            Instruction_a_btn();
        }
    }

    public void okay_a_btn()
    {
        Instruction_a_index += 1;

        if(Instruction_a_index > Instruction_max)
        {
            Instruction_a_index = Instruction_max;
            Instruction_d_btn();
        }
    }

    public void okay_d_btn()
    {
        Instruction_d_index += 1;

        if(Instruction_d_index > Instruction_max)
        {
            Instruction_d_index = Instruction_max;
            Instruction_theta_btn();
        }
    }

    public void okay_theta_btn()
    {
        Instruction_theta_index += 1;

        if(Instruction_theta_index > Instruction_max)
        {
            Instruction_theta_index = Instruction_max;
            Instruction_theta.SetActive(false);
        }
    }

    public void DHTable_btn(int answer)
    {
        /*
        if (DH_Table_Element[Answer].GetComponent<Image>().color == Color.yellow || DH_Table_Element[Answer].GetComponent<Image>().color == Color.red)
        {
            DH_Table_Element[Answer].GetComponent<Image>().color = Color.white;
        }
        */

        Answer = answer;
        DH_Table_Element[Answer].GetComponent<Image>().color = Color.yellow;

        Correct_Stage = 0;
        Candidate = "";

        int n = 0;
        int i = 0;
        n = answer % 4;
        i = answer / 4;

        switch(n)
        {
            case 0:
                Hint_list[1].SetActive(false);
                Hint_list[0].SetActive(true);
                
                Angle.text = "α" + i.ToString();
                break;
            case 1:
                Hint_list[0].SetActive(false);
                Hint_list[1].SetActive(true);

                Distance.text = "a" + i.ToString();
                break;
            case 2:
                Hint_list[0].SetActive(false);
                Hint_list[1].SetActive(true);

                Distance.text = "d" + (i + 1).ToString();
                break;
            case 3:
                Hint_list[1].SetActive(false);
                Hint_list[0].SetActive(true);

                Angle.text = "θ" + (i + 1).ToString();
                break;
        }

        Angle_fill1.text = "_";
        Distance_fill1.text = "_";

        Angle_fill2.text = "_";
        Distance_fill2.text = "_";

        Correct_marker.SetActive(false);
        Wrong_marker.SetActive(false);

    }

    public void Confirm_btn()
    {
        Candidate = Selected_axis;
        Answer_state = true;

        if(Angle_fill1.text == "_")
        {
            Angle_fill1.text = Candidate;
            Distance_fill1.text = Candidate;
        }
        else if (Angle_fill2.text == "_")
        {
            if (Candidate != Angle_fill1.text)
            {
                Angle_fill2.text = Candidate;
                Distance_fill2.text = Candidate;
            }
            }
        else
        {
            Angle_fill1.text = Candidate;
            Distance_fill1.text = Candidate;

            Angle_fill2.text = "_";
            Distance_fill2.text = "_";

            Correct_marker.SetActive(false);
            Wrong_marker.SetActive(false);
        }
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
                if (hit.collider.gameObject != Previous_Axis)
                {
                    hit.collider.gameObject.transform.GetChild(3).gameObject.SetActive(true);

                    if(Previous_Axis != null)
                    {
                        Previous_Axis.transform.GetChild(3).gameObject.SetActive(false);
                    }
                }

                Selected_axis = hit.collider.gameObject.name;

                Previous_Axis = hit.collider.gameObject;
            }

        }

        if(Answer_state)
        {
            if(Candidate == answerA)
            {
                Correct_Stage = 1;
                Answer_state = false;
            }
            else if (Correct_Stage == 1)
            {
                if(Candidate == answerB)
                {
                    Correct_Stage = 2;
                }
            }
            else
            {
                Correct_Stage = -1;
            }


        }
            
        //if (Candidate == answerA && Candidate != "")
        //{
        //    Correct_Stage = 1;
        //    if (Candidate == answerB && Candidate != "")
        //    {
        //        Correct_Stage = 2;
        //    }
        //    //else if (Candidate == answerB)
        //    //{
        //    //    if (Candidate == answerA)
        //    //    {
        //    //        DH_Table_Element[Answer].GetComponent<Image>().color = Color.green;
        //    //    }
        //    //}
        //    else
        //    {
        //        Correct_Stage = -1;
        //        //DH_Table_Element[Answer].GetComponent<Image>().color = Color.red;
        //    }
        //}
        //else if ((Candidate != answerA || Candidate != answerB) && Candidate != "")
        //{
        //    Correct_Stage = -1;
        //    //DH_Table_Element[Answer].GetComponent<Image>().color = Color.red;
        //}

        if (Correct_Stage == 2 && Angle_fill2.text != "_")
        {
            DH_Table_Element[Answer].GetComponent<Image>().color = Color.green;
            Correct_Stage = 0;
            Answer_state = false;
            Correct_marker.SetActive(true);
        }
        else if (Correct_Stage == -1 && Angle_fill2.text != "_")
        {
            DH_Table_Element[Answer].GetComponent<Image>().color = Color.red;
            Correct_Stage = 0;
            Answer_state = false;
            Wrong_marker.SetActive(true);
        }

        //int temp = 0;
        //int temp1 = 0;
        //int temp2 = 0;
        //int temp3 = 0;

        //if (temp != Instruction_alpha_index)
        //{
        //    Instruction_alpha.transform.GetChild(Instruction_alpha_index).gameObject.SetActive(true);
        //    Instruction_alpha.transform.GetChild(temp).gameObject.SetActive(false);

        //    temp = Instruction_alpha_index;
        //}

        if (Angle_fill2.text == "_")
        {
            Correct_marker.SetActive(false);
            Wrong_marker.SetActive(false);
        }

        //if(temp1 != Instruction_a_index)
        //{
        //    Instruction_a.transform.GetChild(Instruction_a_index).gameObject.SetActive(true);
        //    Instruction_a.transform.GetChild(temp1).gameObject.SetActive(false);

        //    temp1 = Instruction_a_index;
        //}



        //if(temp2 != Instruction_d_index)
        //{
        //    Instruction_d.transform.GetChild(Instruction_d_index).gameObject.SetActive(true);
        //    Instruction_d.transform.GetChild(temp2).gameObject.SetActive(false);

        //    temp2 = Instruction_alpha_index;
        //}



        //if(temp3 != Instruction_theta_index)
        //{
        //    Instruction_theta.transform.GetChild(Instruction_theta_index).gameObject.SetActive(true);
        //    Instruction_theta.transform.GetChild(temp3).gameObject.SetActive(false);

        //    temp3 = Instruction_alpha_index;
        //}


        //}

        //for (int i = 0; i < Instruction_max; i++)
        //{
        //    if (i == Instruction_alpha_index)
        //    {
        //        Instruction_alpha.transform.GetChild(Instruction_alpha_index).gameObject.SetActive(true);
        //    }
        //    else if (i != Instruction_alpha_index)
        //    {
        //        Instruction_alpha.transform.GetChild(Instruction_alpha_index).gameObject.SetActive(false);
        //    }

        //    if (i == Instruction_a_index)
        //    {
        //        Instruction_a.transform.GetChild(Instruction_a_index).gameObject.SetActive(true);
        //    }
        //    else if(i != Instruction_a_index)
        //    {
        //        Instruction_a.transform.GetChild(Instruction_a_index).gameObject.SetActive(false);
        //    }

        //    if (i == Instruction_d_index)
        //    {
        //        Instruction_d.transform.GetChild(Instruction_d_index).gameObject.SetActive(true);
        //    }
        //    else if (i != Instruction_d_index)
        //    {
        //        Instruction_d.transform.GetChild(Instruction_d_index).gameObject.SetActive(false);
        //    }

        //    if (i == Instruction_theta_index)
        //    {
        //        Instruction_theta.transform.GetChild(Instruction_theta_index).gameObject.SetActive(true);
        //    }
        //    else if (i != Instruction_theta_index)
        //    {
        //        Instruction_theta.transform.GetChild(Instruction_theta_index).gameObject.SetActive(false);
        //    }

        //}

        for (int i = 0; i <= Instruction_max; i++)
        {
            if (i == Instruction_alpha_index)
            {
                Instruction_alpha.transform.GetChild(i).gameObject.SetActive(true);
               
            }
            else if (i != Instruction_alpha_index)
            {
                Instruction_alpha.transform.GetChild(i).gameObject.SetActive(false);
                
            }

            if (i == Instruction_a_index)
            {
                Instruction_a.transform.GetChild(i).gameObject.SetActive(true);

            }
            else if (i != Instruction_a_index)
            {
                Instruction_a.transform.GetChild(i).gameObject.SetActive(false);

            }

            if (i == Instruction_d_index)
            {
                Instruction_d.transform.GetChild(i).gameObject.SetActive(true);

            }
            else if (i != Instruction_d_index)
            {
                Instruction_d.transform.GetChild(i).gameObject.SetActive(false);

            }

            if (i == Instruction_theta_index)
            {
                Instruction_theta.transform.GetChild(i).gameObject.SetActive(true);

            }
            else if (i != Instruction_theta_index)
            {
                Instruction_theta.transform.GetChild(i).gameObject.SetActive(false);

            }
        }
    }
}
