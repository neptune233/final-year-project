using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Instruction : MonoBehaviour {
    

    // public gameobject for feedback1
    public GameObject ButtonWrong1;
    public GameObject Instruction4;
    public GameObject Instruction5;
    public GameObject Eulerangle;
    public GameObject Movemethod;

    // public gameobject for feedback2
    public GameObject ButtonWrong2;
    public GameObject Add;
    public GameObject Instruction6;

    // public text and gameobject to check the input in num of steps
    public GameObject ButtonWrong3;
    public GameObject Instruction7;
    public GameObject Step1;
    public GameObject Step2;
    public GameObject Step3;
    public GameObject Step4;
    public GameObject NumofStep;
    public GameObject Instruction8;

    // public text and gameobject to check the input in four steps
    public Text step1;
    public Text step2;
    public Text step3;
    public Text step4;
    public GameObject Correct_1;
    public GameObject Wrong_1;
    public GameObject Correct_2;
    public GameObject Wrong_2;
    public GameObject Correct_3;
    public GameObject Wrong_3;
    public GameObject Submitbutton;

    // Check the input for matrix2 and matrix3
    //public Text matrix1;
    public InputField[] M1;
    public InputField[] M2;
    public InputField[] M3;
    //public Text matrix2;
    //public Text matrix3;
    public GameObject Right1;
    public GameObject Right2;
    public GameObject Wrong1;
    public GameObject Wrong2;
    public GameObject Instruction9;
    public GameObject Instruction10;
    public GameObject Button;

    //
    public InputField[] T03;
    public GameObject Right3;
    public GameObject Wrong3;
    public GameObject Hint;

    public InputField[] T04;
    public GameObject Right4;
    public GameObject Wrong4;
    public GameObject Hint2;
    public GameObject Check;
    
    // Function for Move Method
    public void Button_1()
    {
        Scene scene = SceneManager.GetActiveScene();
        
        // Case for scene 1 and 2 
        if (scene.name.Equals("1") || scene.name.Equals("2"))
        {
            // Show feedback when user choose "fixed angle" button
            if (Buttonid.id != 2 )
            {
                ButtonWrong1.SetActive(true);
            }
        
            if (Buttonid.id == 2 )
            {
                Movemethod.SetActive(false);
                Eulerangle.SetActive(true);
                Instruction4.SetActive(false);
                ButtonWrong1.SetActive(false);
                Instruction5.SetActive(true);
            }
        }
        
        else
        {
            if (Buttonid.id == 1)
            {

            }
            if (Buttonid.id == 2)
            {

            }
        }
    }

    public void Button_2()
    {
        Scene scene = SceneManager.GetActiveScene();

        Debug.Log(Buttonid.id);
        if (scene.name.Equals("1")) {
            
            if (Buttonid.id != 3)
            {
                ButtonWrong2.SetActive(true);
            }
            if (Buttonid.id == 3)
            {
                Eulerangle.SetActive(false);
                Add.SetActive(true);
                Instruction5.SetActive(false);
                ButtonWrong2.SetActive(false);
                Instruction6.SetActive(true);

            }
        }
        if (scene.name.Equals("2"))
           
        {
            if (Buttonid.id != 4)
            {
                ButtonWrong2.SetActive(true);
            }
            if (Buttonid.id == 4)
            {
                Eulerangle.SetActive(false);
                Add.SetActive(true);
                Instruction5.SetActive(false);
                ButtonWrong2.SetActive(false);
                Instruction6.SetActive(true);
                Instruction7.SetActive(true);
            }
        }
   
    }

    public void Button_3()
    {
        Scene scene = SceneManager.GetActiveScene();

        if (scene.name.Equals("1")) { 
            if (Submit.NumofStep!=4)
            {
            ButtonWrong3.SetActive(true);
            }
            if (Submit.NumofStep == 4)
            {
                ButtonWrong3.SetActive(false);
                Instruction7.SetActive(false);
                Step1.SetActive(true);
                Step2.SetActive(true);
                Step3.SetActive(true);
                Step4.SetActive(true);
                NumofStep.SetActive(false);
                Instruction8.SetActive(true);
            }
        }
    }


    public void Check_1()
    {
       
        if(step1.text.Equals("R y 30"))
        {
            Correct_1.SetActive(true);
            Wrong_1.SetActive(false);
            Debug.Log("true");
        }
        else
        {
            Wrong_1.SetActive(true);
            Debug.Log("wrong");
        }
    }

    public void Check_2and3()
    {
        //if(step2.text.Equals("R x 45") && step3.text.Equals("R z 60"))
        if(step2.text.Equals("R x 45") && step3.text.Equals("R z 60"))
        {
            Correct_2.SetActive(true);
            Wrong_2.SetActive(false);
        }
        else
        {
            Wrong_2.SetActive(true);
        }
    }

    public void Check_4()
    {
        if(step4.text.Equals("T 10 -5 4"))
        {
            Correct_3.SetActive(true);
            Wrong_3.SetActive(false);
            Submitbutton.SetActive(true);
        }
        else
        {
            Wrong_3.SetActive(true);
        }
    }

    public void Example()
    {
        //m1.text = "0.866 0 0.5 0\n0 1 0 0\n-0.5 0 0.866 0\n0 0 0 1";  
        M1[0].text = "0.866";
        M1[1].text = "0";
        M1[2].text = "0.5";
        M1[3].text = "0";
        M1[4].text = "0";
        M1[5].text = "1";
        M1[6].text = "0";
        M1[7].text = "0";
        M1[8].text = "-0.5";
        M1[9].text = "0";
        M1[10].text = "0.866";
        M1[11].text = "0";
        M1[12].text = "0";
        M1[13].text = "0";
        M1[14].text = "0";
        M1[15].text = "1";
    }

    /*
    public void Checkmatrix()
    {
        bool state1=false;
        bool state2=false;
        bool error2 = true;
        float temp;
        string Data2 = matrix2.text;
        string[] numberlist2 = Data2.Split();
        if (numberlist2.Length == 16)
        {
            for (int i = 0; i < numberlist2.Length; i++)
            {
                if (float.TryParse(numberlist2[i], out temp) == false)
                {
                    error2 = false;
                    break;
                }
            }
            if (error2 == true)
            {
                if (Mathf.Abs(float.Parse(numberlist2[0]) - 1f) < 0.01f && Mathf.Abs(float.Parse(numberlist2[1])) < 0.01f && Mathf.Abs(float.Parse(numberlist2[2])) < 0.01f && Mathf.Abs(float.Parse(numberlist2[3])) < 0.01f && Mathf.Abs(float.Parse(numberlist2[4])) < 0.01f && Mathf.Abs(float.Parse(numberlist2[5]) - 0.707f) < 0.01f && Mathf.Abs(float.Parse(numberlist2[6]) + 0.707f) < 0.01f && Mathf.Abs(float.Parse(numberlist2[7])) < 0.01f && Mathf.Abs(float.Parse(numberlist2[8])) < 0.01f && Mathf.Abs(float.Parse(numberlist2[9])) - 0.707f < 0.01f && Mathf.Abs(float.Parse(numberlist2[10])) - 0.707f < 0.01f && Mathf.Abs(float.Parse(numberlist2[11])) < 0.01f && Mathf.Abs(float.Parse(numberlist2[12])) < 0.01f && Mathf.Abs(float.Parse(numberlist2[13])) < 0.01f && Mathf.Abs(float.Parse(numberlist2[14])) < 0.01 && Mathf.Abs(float.Parse(numberlist2[15]) - 1f) < 0.01f)
                {
                    Right1.SetActive(true);
                    Wrong1.SetActive(false);
                    state1 = true;
                }
                else
                {
                    Wrong1.SetActive(true);
                    Right1.SetActive(false);
                   
                }
            }
        }
        bool error3 = true;
        string Data3 = matrix3.text;
        string[] numberlist3 = Data3.Split();
        if (numberlist3.Length == 16)
        {
            for (int i = 0; i < numberlist3.Length; i++)
            {
                if (float.TryParse(numberlist3[i], out temp) == false)
                {
                    error3 = false;
                    break;
                }
            }

            if (error3 == true)
            {
                if (Mathf.Abs(float.Parse(numberlist3[0]) - 0.5f) < 0.01f && Mathf.Abs(float.Parse(numberlist3[1]) + 0.866f) < 0.01f && Mathf.Abs(float.Parse(numberlist3[2])) < 0.01f && Mathf.Abs(float.Parse(numberlist3[3])) < 0.01f && Mathf.Abs(float.Parse(numberlist3[4]) - 0.866f) < 0.01f && Mathf.Abs(float.Parse(numberlist3[5]) - 0.5f) < 0.01f && Mathf.Abs(float.Parse(numberlist3[6])) < 0.01f && Mathf.Abs(float.Parse(numberlist3[7])) < 0.01f && Mathf.Abs(float.Parse(numberlist3[8])) < 0.01f && Mathf.Abs(float.Parse(numberlist3[9])) < 0.01f && Mathf.Abs(float.Parse(numberlist3[10])) - 1f < 0.01f && Mathf.Abs(float.Parse(numberlist3[11])) < 0.01f && Mathf.Abs(float.Parse(numberlist3[12])) < 0.01f && Mathf.Abs(float.Parse(numberlist3[13])) < 0.01f && Mathf.Abs(float.Parse(numberlist3[14])) < 0.01 && Mathf.Abs(float.Parse(numberlist3[15]) - 1f) < 0.01f)
                {
                    Right2.SetActive(true);
                    Wrong2.SetActive(false);
                    state2 = true;
                }
                else
                {
                    Wrong2.SetActive(true);
                    Right2.SetActive(false);
                   
                }
            }
        }
        
        if( state1==true && state2 == true)
        {
            Instruction9.SetActive(false);
            Instruction10.SetActive(true);
            Button.SetActive(true);
        }
    }
    */
    public void Checkmatrix()
    {
        bool state1 = false;
        bool state2 = false;
        bool error2 = true;
        float temp;

        for (int i = 0; i < 16; i++)
        {
            if (float.TryParse(M2[i].text, out temp) == false)
            {
                error2 = false;
                break;
            }
        }
        if (error2 == true)
            {
                if (Mathf.Abs(float.Parse(M2[0].text) - 1f) < 0.01f && Mathf.Abs(float.Parse(M2[1].text)) < 0.01f && Mathf.Abs(float.Parse(M2[2].text)) < 0.01f && Mathf.Abs(float.Parse(M2[3].text)) < 0.01f && Mathf.Abs(float.Parse(M2[4].text)) < 0.01f && Mathf.Abs(float.Parse(M2[5].text) - 0.707f) < 0.01f && Mathf.Abs(float.Parse(M2[6].text) + 0.707f) < 0.01f && Mathf.Abs(float.Parse(M2[7].text)) < 0.01f && Mathf.Abs(float.Parse(M2[8].text)) < 0.01f && Mathf.Abs(float.Parse(M2[9].text) - 0.707f) < 0.01f && Mathf.Abs(float.Parse(M2[10].text) - 0.707f) < 0.01f && Mathf.Abs(float.Parse(M2[11].text)) < 0.01f && Mathf.Abs(float.Parse(M2[12].text)) < 0.01f && Mathf.Abs(float.Parse(M2[13].text)) < 0.01f && Mathf.Abs(float.Parse(M2[14].text)) < 0.01 && Mathf.Abs(float.Parse(M2[15].text) - 1f) < 0.01f)
                {
                    Right1.SetActive(true);
                    Wrong1.SetActive(false);
                    state1 = true;
                }
                else
                {
                    Wrong1.SetActive(true);
                    Right1.SetActive(false);

                }
            }
        
        bool error3 = true;
    
         for (int i = 0; i< 16; i++)
        {
            if (float.TryParse(M3[i].text, out temp) == false)
            {
                error3 = false;
                break;
            }
        }
        if (error3 == true)
            {
                if (Mathf.Abs(float.Parse(M3[0].text) - 0.5f) < 0.01f && Mathf.Abs(float.Parse(M3[1].text)+0.866f) < 0.01f && Mathf.Abs(float.Parse(M3[2].text)) < 0.01f && Mathf.Abs(float.Parse(M3[3].text)) < 0.01f && Mathf.Abs(float.Parse(M3[4].text)-0.866f) < 0.01f && Mathf.Abs(float.Parse(M3[5].text) - 0.5f) < 0.01f && Mathf.Abs(float.Parse(M3[6].text)) < 0.01f && Mathf.Abs(float.Parse(M3[7].text)) < 0.01f && Mathf.Abs(float.Parse(M3[8].text)) < 0.01f && Mathf.Abs(float.Parse(M3[9].text))< 0.01f && Mathf.Abs(float.Parse(M3[10].text) - 1f) < 0.01f && Mathf.Abs(float.Parse(M3[11].text)) < 0.01f && Mathf.Abs(float.Parse(M3[12].text)) < 0.01f && Mathf.Abs(float.Parse(M3[13].text)) < 0.01f && Mathf.Abs(float.Parse(M3[14].text)) < 0.01 && Mathf.Abs(float.Parse(M3[15].text) - 1f) < 0.01f)
                {
                    Right2.SetActive(true);
                    Wrong2.SetActive(false);
                    state2 = true;
                }
                else
                {
                    Wrong2.SetActive(true);
                    Right2.SetActive(false);

                }
            }
        

        if (state1 == true && state2 == true)
        {
            Instruction9.SetActive(false);
            Instruction10.SetActive(true);
            Button.SetActive(true);
        }
    }


    /*
    public void Check0T3()
    {
        bool error4 = true;
        float temp;
        string Data4 = T03.text;
        string[] numberlist4 = Data4.Split();
        if (numberlist4.Length == 16)
        {
            for (int i = 0; i < numberlist4.Length; i++)
            {
                if (float.TryParse(numberlist4[i], out temp) == false)
                {
                    error4 = false;
                    break;
                }
            }

            if (error4 == true)
            {
                if (Mathf.Abs(float.Parse(numberlist4[0])-0.739f)< 0.02f && Mathf.Abs(float.Parse(numberlist4[1]) + 0.573f) < 0.02f && Mathf.Abs(float.Parse(numberlist4[2])-0.354f) < 0.02f && Mathf.Abs(float.Parse(numberlist4[3])) < 0.02f && Mathf.Abs(float.Parse(numberlist4[4]) - 0.612f) < 0.02f && Mathf.Abs(float.Parse(numberlist4[5]) - 0.354f) < 0.02f && Mathf.Abs(float.Parse(numberlist4[6])+0.707f) < 0.02f && Mathf.Abs(float.Parse(numberlist4[7])) < 0.02f && Mathf.Abs(float.Parse(numberlist4[8])-0.28f) < 0.02f && Mathf.Abs(float.Parse(numberlist4[9])-0.739f) < 0.02f && Mathf.Abs(float.Parse(numberlist4[10]) - 0.612f) < 0.02f && Mathf.Abs(float.Parse(numberlist4[11])) < 0.02f && Mathf.Abs(float.Parse(numberlist4[12])) < 0.02f && Mathf.Abs(float.Parse(numberlist4[13])) < 0.02f && Mathf.Abs(float.Parse(numberlist4[14])) < 0.02f && Mathf.Abs(float.Parse(numberlist4[15]) - 1f) < 0.02f)
                {
                    Right3.SetActive(true);
                    Wrong3.SetActive(false);
                    Hint.SetActive(true);
                }
                else
                {
                    Wrong3.SetActive(true);
                    Right3.SetActive(false);

                }
            }
        }
    }
    */

    public void Check0T3()
    {
        float temp;
        bool error4 = true;
        for (int i = 0; i < 16; i++)
        {
            if (float.TryParse(T03[i].text, out temp) == false)
            {
                error4 = false;
                break;
            }
        }
        if (error4 == true)
        {
            if (Mathf.Abs(float.Parse(T03[0].text) - 0.739f) < 0.01f && Mathf.Abs(float.Parse(T03[1].text)+0.573f) < 0.01f && Mathf.Abs(float.Parse(T03[2].text)-0.354f) < 0.01f && Mathf.Abs(float.Parse(T03[3].text)) < 0.01f && Mathf.Abs(float.Parse(T03[4].text)-0.612f) < 0.01f && Mathf.Abs(float.Parse(T03[5].text) - 0.354f) < 0.01f && Mathf.Abs(float.Parse(T03[6].text) + 0.707f) < 0.01f && Mathf.Abs(float.Parse(T03[7].text)) < 0.01f && Mathf.Abs(float.Parse(T03[8].text)-0.28f) < 0.01f && Mathf.Abs(float.Parse(T03[9].text) - 0.739f) < 0.01f && Mathf.Abs(float.Parse(T03[10].text) - 0.612f) < 0.01f && Mathf.Abs(float.Parse(T03[11].text)) < 0.01f && Mathf.Abs(float.Parse(T03[12].text)) < 0.01f && Mathf.Abs(float.Parse(T03[13].text)) < 0.01f && Mathf.Abs(float.Parse(T03[14].text)) < 0.01 && Mathf.Abs(float.Parse(T03[15].text) - 1f) < 0.01f)
            {
                Right3.SetActive(true);
                Wrong3.SetActive(false);
                Hint.SetActive(true);
            }
            else
            {
                Wrong3.SetActive(true);
                Right3.SetActive(false);

            }
        }
    }

    /*
    public void Check0T4()
    {
        bool error5 = true;
        float temp;
        string Data5 = T40.text;
        string[] numberlist5 = Data5.Split();
        if (numberlist5.Length == 16)
        {
            for (int i = 0; i < numberlist5.Length; i++)
            {
                if (float.TryParse(numberlist5[i], out temp) == false)
                {
                    error5 = false;
                    break;
                }
            }

            if (error5 == true)
            {
                if (Mathf.Abs(float.Parse(numberlist5[0]) - 0.739f) < 0.02f && Mathf.Abs(float.Parse(numberlist5[1]) - 0.612f) < 0.02f && Mathf.Abs(float.Parse(numberlist5[2]) - 0.28f) < 0.02f && Mathf.Abs(float.Parse(numberlist5[3])+5.45f) < 0.02f && Mathf.Abs(float.Parse(numberlist5[4]) + 0.573f) < 0.02f && Mathf.Abs(float.Parse(numberlist5[5]) - 0.354f) < 0.02f && Mathf.Abs(float.Parse(numberlist5[6]) - 0.739f) < 0.02f && Mathf.Abs(float.Parse(numberlist5[7])-4.54f) < 0.02f && Mathf.Abs(float.Parse(numberlist5[8]) - 0.354f) < 0.02f && Mathf.Abs(float.Parse(numberlist5[9]) + 0.707f) < 0.02f && Mathf.Abs(float.Parse(numberlist5[10]) - 0.612f) < 0.02f && Mathf.Abs(float.Parse(numberlist5[11])+9.52f) < 0.02f && Mathf.Abs(float.Parse(numberlist5[12])) < 0.02f && Mathf.Abs(float.Parse(numberlist5[13])) < 0.02f && Mathf.Abs(float.Parse(numberlist5[14])) < 0.02f && Mathf.Abs(float.Parse(numberlist5[15]) - 1f) < 0.02f)
                {
                    Right4.SetActive(true);
                    Wrong4.SetActive(false);
                    Hint2.SetActive(true);
                    Check.SetActive(false);
                    Debug.Log("A");
                }
                else
                {
                    Wrong4.SetActive(true);
                    Right4.SetActive(false);
                    Debug.Log("B");
                }
            }
        }
    }
    */

    public void Check0T4()
    {
        float temp;
        bool error5 = true;
        for (int i = 0; i < 16; i++)
        {
            if (float.TryParse(T04[i].text, out temp) == false)
            {
                error5 = false;
                break;
            }
        }
        if (error5 == true)
        {
            if (Mathf.Abs(float.Parse(T04[0].text) - 0.739f) < 0.01f && Mathf.Abs(float.Parse(T04[1].text) + 0.573f) < 0.01f && Mathf.Abs(float.Parse(T04[2].text) - 0.354f) < 0.01f && Mathf.Abs(float.Parse(T03[3].text) - 10f) < 0.01f && Mathf.Abs(float.Parse(T03[4].text) - 0.612f) < 0.01f && Mathf.Abs(float.Parse(T03[5].text) - 0.354f) < 0.01f && Mathf.Abs(float.Parse(T03[6].text) + 0.707f) < 0.01f && Mathf.Abs(float.Parse(T03[7].text) + 5f) < 0.01f && Mathf.Abs(float.Parse(T03[8].text) - 0.28f) < 0.01f && Mathf.Abs(float.Parse(T03[9].text) - 0.739f) < 0.01f && Mathf.Abs(float.Parse(T03[10].text) - 0.612f) < 0.01f && Mathf.Abs(float.Parse(T03[11].text) - 4f) < 0.01f && Mathf.Abs(float.Parse(T03[12].text)) < 0.01f && Mathf.Abs(float.Parse(T03[13].text)) < 0.01f && Mathf.Abs(float.Parse(T03[14].text)) < 0.01 && Mathf.Abs(float.Parse(T03[15].text) - 1f) < 0.01f)
            {
                Right3.SetActive(true);
                Wrong3.SetActive(false);
                Hint.SetActive(true);
            }
            else
            {
                Wrong3.SetActive(true);
                Right3.SetActive(false);

            }
        }
    }


}


