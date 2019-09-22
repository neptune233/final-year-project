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

    // public text and gameobject to check the input in num of matrices
    public GameObject ButtonWrong4;
    public GameObject NumofMatrix;

    // Check the input for matrix2 and matrix3
    //public Text matrix1;
    public InputField[] M1;
    public InputField[] M2;
    public InputField[] M3;
    public GameObject[] WrongBlock;
   

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

    public InputField[] T40;
    public GameObject Right4;
    public GameObject Wrong4;
    public GameObject Hint2;
    public GameObject Check;

    public GameObject InputCorrect;
    public GameObject InputWrong;
    public GameObject Matrix1;
    public GameObject Matrix2;
    public GameObject Matrix3;
    public GameObject Submatrix;

    public GameObject Ans;
    public GameObject User;
    public CanvasGroup submitbutton;
  
   
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
    

    // When user press the wrong button in move method, give user a feedback 
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
                Instruction5.SetActive(false);
                ButtonWrong2.SetActive(false);
                Instruction7.SetActive(true);
            }
        }
   
    }

    public void Button_3()
    {
        Scene scene = SceneManager.GetActiveScene();

        
    
        if (scene.name.Equals("Transformationmatrix"))
        {
            if(Submit.NumofMatrix!=3)
            {
                ButtonWrong4.SetActive(true);
            }
            else if(Submit.NumofMatrix==3)
            {
                ButtonWrong4.SetActive(false);
                Matrix1.SetActive(true);
                Matrix2.SetActive(true);
                Matrix3.SetActive(true);
                NumofMatrix.SetActive(false);
                Instruction7.SetActive(false);
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

        M2[0].text = "1";
        M2[1].text = "0";
        M2[2].text = "0";
        M2[3].text = "0";
        M2[4].text = "0";
        M2[5].text = "1";
        M2[6].text = "0";
        M2[7].text = "0";
        M2[8].text = "0";
        M2[9].text = "0";
        M2[10].text = "1";
        M2[11].text = "0";
        M2[12].text = "0";
        M2[13].text = "0";
        M2[14].text = "0";
        M2[15].text = "1";

        M3[0].text = "1";
        M3[1].text = "0";
        M3[2].text = "0";
        M3[3].text = "0";
        M3[4].text = "0";
        M3[5].text = "1";
        M3[6].text = "0";
        M3[7].text = "0";
        M3[8].text = "0";
        M3[9].text = "0";
        M3[10].text = "1";
        M3[11].text = "0";
        M3[12].text = "0";
        M3[13].text = "0";
        M3[14].text = "0";
        M3[15].text = "1";
    }

   
    public void Checkmatrix()
    {

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
            if (Mathf.Abs(float.Parse(M2[0].text) - 1f) > 0.01f)
            {
                WrongBlock[0].SetActive(true);
            }
            else
            {
                WrongBlock[0].SetActive(false);
            }
            if (Mathf.Abs(float.Parse(M2[1].text)) > 0.01f)
            {
                WrongBlock[1].SetActive(true);
            }
            else
            {
                WrongBlock[1].SetActive(false);
            }
            if (Mathf.Abs(float.Parse(M2[2].text)) > 0.01f)
            {
                WrongBlock[2].SetActive(true);
            }
            else
            {
                WrongBlock[2].SetActive(false);
            }
            if (Mathf.Abs(float.Parse(M2[3].text)) > 0.01f)
            {
                WrongBlock[3].SetActive(true);
            }
            else
            {
                WrongBlock[3].SetActive(false);
            }
            if (Mathf.Abs(float.Parse(M2[4].text)) > 0.01f)
            {
                WrongBlock[4].SetActive(true);
            }
            else
            {
                WrongBlock[4].SetActive(false);
            }
            if (Mathf.Abs(float.Parse(M2[5].text) - 0.707f) > 0.01f)
            {
                WrongBlock[5].SetActive(true);
            }
            else
            {
                WrongBlock[5].SetActive(false);
            }
            if (Mathf.Abs(float.Parse(M2[6].text) + 0.707f) > 0.01f)
            {
                WrongBlock[6].SetActive(true);
            }
            else
            {
                WrongBlock[6].SetActive(false);
            }
            if (Mathf.Abs(float.Parse(M2[7].text)) > 0.01f)
            {
                WrongBlock[7].SetActive(true);
            }
            else
            {
                WrongBlock[7].SetActive(false);
            }
            if (Mathf.Abs(float.Parse(M2[8].text)) > 0.01f)
            {
                WrongBlock[8].SetActive(true);
            }
            else
            {
                WrongBlock[8].SetActive(false);
            }
            if (Mathf.Abs(float.Parse(M2[9].text) - 0.707f) > 0.01f)
            {
                WrongBlock[9].SetActive(true);
            }
            else
            {
                WrongBlock[9].SetActive(false);
            }
            if (Mathf.Abs(float.Parse(M2[10].text) - 0.707f) > 0.01f)
            {
                WrongBlock[10].SetActive(true);
            }
            else
            {
                WrongBlock[10].SetActive(false);
            }
            if (Mathf.Abs(float.Parse(M2[11].text)) > 0.01f)
            {
                WrongBlock[11].SetActive(true);
            }
            else
            {
                WrongBlock[11].SetActive(false);
            }
            if (Mathf.Abs(float.Parse(M2[12].text)) > 0.01f)
            {
                WrongBlock[12].SetActive(true);
            }
            else
            {
                WrongBlock[12].SetActive(false);
            }
            if (Mathf.Abs(float.Parse(M2[13].text)) > 0.01f)
            {
                WrongBlock[13].SetActive(true);
            }
            else
            {
                WrongBlock[13].SetActive(false);
            }
            if (Mathf.Abs(float.Parse(M2[14].text)) > 0.01f)
            {
                WrongBlock[14].SetActive(true);
            }
            else
            {
                WrongBlock[14].SetActive(false);
            }
            if (Mathf.Abs(float.Parse(M2[15].text) - 1f) > 0.01f)
            {
                WrongBlock[15].SetActive(true);
            }
            else
            {
                WrongBlock[15].SetActive(false);
            }
        }

        bool error3 = true;
        

        for (int i = 0; i < 16; i++)
        {
            if (float.TryParse(M3[i].text, out temp) == false)
            {
                error3 = false;
                break;
            }
        }
        if (error3 == true)
        {
            if (Mathf.Abs(float.Parse(M3[0].text) - 0.5f) > 0.01f)
            {
                WrongBlock[16].SetActive(true);
            }
            else
            {
                WrongBlock[16].SetActive(false);
            }
            if (Mathf.Abs(float.Parse(M3[1].text)+0.866f) > 0.01f)
            {
                WrongBlock[17].SetActive(true);
            }
            else
            {
                WrongBlock[17].SetActive(false);
            }
            if (Mathf.Abs(float.Parse(M3[2].text)) > 0.01f)
            {
                WrongBlock[18].SetActive(true);
            }
            else
            {
                WrongBlock[18].SetActive(false);
            }
            if (Mathf.Abs(float.Parse(M3[3].text)) > 0.01f)
            {
                WrongBlock[19].SetActive(true);
            }
            else
            {
                WrongBlock[19].SetActive(false);
            }
            if (Mathf.Abs(float.Parse(M3[4].text)-0.866f) > 0.01f)
            {
                WrongBlock[20].SetActive(true);
            }
            else
            {
                WrongBlock[20].SetActive(false);
            }
            if (Mathf.Abs(float.Parse(M3[5].text) - 0.5f) > 0.01f)
            {
                WrongBlock[21].SetActive(true);
            }
            else
            {
                WrongBlock[21].SetActive(false);
            }
            if (Mathf.Abs(float.Parse(M3[6].text)) > 0.01f)
            {
                WrongBlock[22].SetActive(true);
            }
            else
            {
                WrongBlock[22].SetActive(false);
            }
            if (Mathf.Abs(float.Parse(M3[7].text)) > 0.01f)
            {
                WrongBlock[23].SetActive(true);
            }
            else
            {
                WrongBlock[23].SetActive(false);
            }
            if (Mathf.Abs(float.Parse(M3[8].text)) > 0.01f)
            {
                WrongBlock[24].SetActive(true);
            }
            else
            {
                WrongBlock[24].SetActive(false);
            }
            if (Mathf.Abs(float.Parse(M3[9].text)) > 0.01f)
            {
                WrongBlock[25].SetActive(true);
            }
            else
            {
                WrongBlock[25].SetActive(false);
            }
            if (Mathf.Abs(float.Parse(M3[10].text) - 1f) > 0.01f)
            {
                WrongBlock[26].SetActive(true);
            }
            else
            {
                WrongBlock[26].SetActive(false);
            }
            if (Mathf.Abs(float.Parse(M3[11].text)) > 0.01f)
            {
                WrongBlock[27].SetActive(true);
            }
            else
            {
                WrongBlock[27].SetActive(false);
            }
            if (Mathf.Abs(float.Parse(M3[12].text)) > 0.01f)
            {
                WrongBlock[28].SetActive(true);
            }
            else
            {
                WrongBlock[28].SetActive(false);
            }
            if (Mathf.Abs(float.Parse(M3[13].text)) > 0.01f)
            {
                WrongBlock[29].SetActive(true);
            }
            else
            {
                WrongBlock[29].SetActive(false);
            }
            if (Mathf.Abs(float.Parse(M3[14].text)) > 0.01f)
            {
                WrongBlock[30].SetActive(true);
            }
            else
            {
                WrongBlock[30].SetActive(false);
            }
            if (Mathf.Abs(float.Parse(M3[15].text) - 1f) > 0.01f)
            {
                WrongBlock[31].SetActive(true);
            }
            else
            {
                WrongBlock[31].SetActive(false);
            }
        }
        bool Input = true;

        for(int j = 0; j < 32; j++)
        {
            if (WrongBlock[j].activeInHierarchy == true)
            {
                Input = false;
            }
        }

        if (Input==true)
        {
            InputCorrect.SetActive(true);
        }
        else
        {
            InputWrong.SetActive(true);
            Matrix3.SetActive(true);
            Matrix2.SetActive(true);
            Submatrix.SetActive(true);

        }

    }

        /*
        bool error3 = true;

        for (int i = 0; i < 16; i++)
        {
            if (float.TryParse(M3[i].text, out temp) == false)
            {
                error3 = false;
                break;
            }
        }
        if (error3 == true)
        {
            if (Mathf.Abs(float.Parse(M3[0].text) - 0.5f) < 0.01f && Mathf.Abs(float.Parse(M3[1].text) + 0.866f) < 0.01f && Mathf.Abs(float.Parse(M3[2].text)) < 0.01f && Mathf.Abs(float.Parse(M3[3].text)) < 0.01f && Mathf.Abs(float.Parse(M3[4].text) - 0.866f) < 0.01f && Mathf.Abs(float.Parse(M3[5].text) - 0.5f) < 0.01f && Mathf.Abs(float.Parse(M3[6].text)) < 0.01f && Mathf.Abs(float.Parse(M3[7].text)) < 0.01f && Mathf.Abs(float.Parse(M3[8].text)) < 0.01f && Mathf.Abs(float.Parse(M3[9].text)) < 0.01f && Mathf.Abs(float.Parse(M3[10].text) - 1f) < 0.01f && Mathf.Abs(float.Parse(M3[11].text)) < 0.01f && Mathf.Abs(float.Parse(M3[12].text)) < 0.01f && Mathf.Abs(float.Parse(M3[13].text)) < 0.01f && Mathf.Abs(float.Parse(M3[14].text)) < 0.01 && Mathf.Abs(float.Parse(M3[15].text) - 1f) < 0.01f)
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

    public void Check4T0()
    {
        float temp;
        bool error5 = true;
        for (int i = 0; i < 16; i++)
        {
            if (float.TryParse(T40[i].text, out temp) == false)
            {
                error5 = false;
                break;
            }
        }
        if (error5 == true)
        {
            if (Mathf.Abs(float.Parse(T40[0].text) - 0.739f) < 0.01f && Mathf.Abs(float.Parse(T40[1].text) - 0.612f) < 0.01f && Mathf.Abs(float.Parse(T40[2].text) - 0.28f) < 0.01f && Mathf.Abs(float.Parse(T40[3].text) + 5.45f) < 0.01f && Mathf.Abs(float.Parse(T40[4].text) + 0.573f) < 0.01f && Mathf.Abs(float.Parse(T40[5].text) - 0.354f) < 0.01f && Mathf.Abs(float.Parse(T40[6].text) - 0.739f) < 0.01f && Mathf.Abs(float.Parse(T40[7].text) - 4.54f) < 0.01f && Mathf.Abs(float.Parse(T40[8].text) - 0.354f) < 0.01f && Mathf.Abs(float.Parse(T40[9].text) + 0.707f) < 0.01f && Mathf.Abs(float.Parse(T40[10].text) - 0.612f) < 0.01f && Mathf.Abs(float.Parse(T40[11].text) + 9.52f) < 0.01f && Mathf.Abs(float.Parse(T40[12].text)) < 0.01f && Mathf.Abs(float.Parse(T40[13].text)) < 0.01f && Mathf.Abs(float.Parse(T40[14].text)) < 0.01 && Mathf.Abs(float.Parse(T40[15].text) - 1f) < 0.01f)
            {
                Right4.SetActive(true);
                Wrong4.SetActive(false);
                Hint2.SetActive(true);
                Check.SetActive(false);
            }
            else
            {
                Wrong4.SetActive(true);
                Right4.SetActive(false);

            }
        }
    }

    public void Reset()
    {
        Ans.transform.localPosition = new Vector3(0, 0.2f, 0.18f);
        Ans.transform.localRotation = new Quaternion(0, 0, 0, 0);
        User.transform.localPosition = new Vector3(0, 0.2f, -0.3f);
        User.transform.localRotation = new Quaternion(0, 0, 0, 0);
        Buttonid.Step = 0;
        if (GameObject.Find("ref1"))
        {
            Destroy(GameObject.Find("ref1"));
        }
        if (GameObject.Find("ref2"))
        {
            Destroy(GameObject.Find("ref2"));
        }
        if (GameObject.Find("ref3"))
        {
            Destroy(GameObject.Find("ref3"));
        }
        if (GameObject.Find("ref4"))
        {
            Destroy(GameObject.Find("ref4"));
        }
        if (GameObject.Find("ansref1"))
        {
            Destroy(GameObject.Find("ansref1"));
        }
        if (GameObject.Find("ansref2"))
        {
            Destroy(GameObject.Find("ansref2"));
        }
        if (GameObject.Find("ansref3"))
        {
            Destroy(GameObject.Find("ansref3"));
        }
        if (GameObject.Find("ansref4"))
        {
            Destroy(GameObject.Find("ansref4"));
        }
        MoveObject_Matrix.Iscreated1 = true;
        MoveObject_Matrix.Iscreated2 = true;
        MoveObject_Matrix.Iscreated3 = true;
        MoveObject_Matrix.Timer1 = 0;
        MoveObject_Matrix.Timer2 = 0;
        MoveObject_Matrix.Timer3 = 0;
    }
    public void Show()
    {
        submitbutton.alpha = 1;
       
    }
   

}


