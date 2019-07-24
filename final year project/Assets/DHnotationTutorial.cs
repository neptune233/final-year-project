using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DHnotationTutorial : MonoBehaviour
{
    public GameObject[] views;
    public GameObject[] frames;
    public int progress_stage;
    public int option_stage; // 1,2,3 ==> choose z-axis  /4,5 ==> choose frame 1  /6,7 ==> choose frame 2  /10,11,12 ==> choose frame 3
    public int option;
    public int correct_option;

    // Start is called before the first frame update
    void Start()
    {
        progress_stage = 1;
        option_stage = 1;
        option = 1;
    }

    // Update is called once per frame
    void Update()
    {
        switch(progress_stage)
        {
            case 1:
                views[0].SetActive(true);
                views[1].SetActive(false);
                views[2].SetActive(false);
                break;
            case 2:
                views[0].SetActive(false);
                views[1].SetActive(true);
                views[2].SetActive(false);

                frames[0].SetActive(true);
                frames[10].SetActive(true);
                break;
            case 3:
                views[0].SetActive(false);
                views[1].SetActive(false);
                views[2].SetActive(true);

                option_progress();

                break;
            case 4:
                break;
            case 5:
                break;
            case 6:
                break;
            case 7:
                break;
            default:
                views[0].SetActive(false);
                views[1].SetActive(false);
                views[2].SetActive(false);
                break;
        }

        

        //switch (option)
        //{
        //    case 1:

        //        break;
        //    case 2:

        //        break;
        //    case 3:

        //        break;
        //    default:

        //        break;
        //}
    }

    public void Next_stage()
    {
        progress_stage += 1;
    }

    public void Back_btn()
    {
        option_stage -= 1;
    }

    public void Previous_option()
    {
        option -= 1;
        if(option < 1)
        {
            option = 1;
        }
    }

    public void Next_option()
    {
        option += 1;
        if(option > 3)
        {
            option = 3;
        }
    }

    public void Confirm_btn()
    {
        if (option == correct_option)
        {
            option_stage += 1;
            option = 1;
        }
        else
        {
            Debug.Log("Error");
        }
    }

    private void option_progress()
    {
        switch (option_stage)
        {
            case 1:
                if (option == 1)
                {
                    frames[2].SetActive(false);
                    frames[3].SetActive(false);

                    frames[1].SetActive(true);
                    frames[1].transform.GetChild(0).gameObject.SetActive(false);
                    frames[1].transform.GetChild(1).gameObject.SetActive(true);
                    frames[1].transform.GetChild(2).gameObject.SetActive(false);
                }
                else if (option == 2)
                {
                    frames[1].SetActive(false);
                    frames[3].SetActive(false);

                    frames[2].SetActive(true);
                    frames[2].transform.GetChild(0).gameObject.SetActive(true);
                    frames[2].transform.GetChild(1).gameObject.SetActive(false);
                    frames[2].transform.GetChild(2).gameObject.SetActive(false);
                }
                else if (option == 3)
                {
                    frames[1].SetActive(false);
                    frames[2].SetActive(false);

                    frames[3].SetActive(true);
                    frames[3].transform.GetChild(0).gameObject.SetActive(false);
                    frames[3].transform.GetChild(1).gameObject.SetActive(false);
                    frames[3].transform.GetChild(2).gameObject.SetActive(true);
                }

                correct_option = 1;

                break;
            case 2:
                if (option == 1)
                {
                    frames[5].SetActive(false);
                    frames[6].SetActive(false);

                    frames[4].SetActive(true);
                    frames[4].transform.GetChild(0).gameObject.SetActive(false);
                    frames[4].transform.GetChild(1).gameObject.SetActive(true);
                    frames[4].transform.GetChild(2).gameObject.SetActive(false);
                }
                else if (option == 2)
                {
                    frames[5].SetActive(false);
                    frames[6].SetActive(false);

                    frames[4].SetActive(true);
                    frames[4].transform.GetChild(0).gameObject.SetActive(false);
                    frames[4].transform.GetChild(1).gameObject.SetActive(false);
                    frames[4].transform.GetChild(2).gameObject.SetActive(true);
                }
                else if (option == 3)
                {
                    frames[6].SetActive(false);
                    frames[4].SetActive(false);

                    frames[5].SetActive(true);
                    frames[5].transform.GetChild(0).transform.GetChild(0).gameObject.SetActive(false);
                    frames[5].transform.GetChild(0).transform.GetChild(1).gameObject.SetActive(true);
                    frames[5].transform.GetChild(0).transform.GetChild(2).gameObject.SetActive(false);

                }

                correct_option = 3;
                break;
            case 3:

                if (option == 1)
                {
                    frames[7].SetActive(false);
                    frames[8].SetActive(false);

                    frames[9].SetActive(true);
                    frames[9].transform.GetChild(0).transform.GetChild(0).gameObject.SetActive(false);
                    frames[9].transform.GetChild(0).transform.GetChild(1).gameObject.SetActive(true);
                    frames[9].transform.GetChild(0).transform.GetChild(2).gameObject.SetActive(false);
                }
                else if (option == 2)
                {
                    frames[7].SetActive(false);
                    frames[8].SetActive(false);

                    frames[9].SetActive(true);
                    frames[9].transform.GetChild(0).transform.GetChild(0).gameObject.SetActive(false);
                    frames[9].transform.GetChild(0).transform.GetChild(1).gameObject.SetActive(true);
                    frames[9].transform.GetChild(0).transform.GetChild(2).gameObject.SetActive(false);
                }
                else if (option == 3)
                {
                    frames[9].SetActive(false);
                    frames[8].SetActive(false);

                    frames[7].SetActive(true);
                    frames[7].transform.GetChild(0).transform.GetChild(0).gameObject.SetActive(false);
                    frames[7].transform.GetChild(0).transform.GetChild(1).gameObject.SetActive(true);
                    frames[7].transform.GetChild(0).transform.GetChild(2).gameObject.SetActive(false);

                }

                correct_option = 3;

                break;
            case 4:
                if (option == 1)
                {
                    frames[2].SetActive(false);
                    frames[3].SetActive(false);

                    frames[1].SetActive(true);
                    frames[1].transform.GetChild(0).gameObject.SetActive(true);
                    frames[1].transform.GetChild(1).gameObject.SetActive(true);
                    frames[1].transform.GetChild(2).gameObject.SetActive(false);
                }
                else if (option == 2)
                {
                    frames[1].transform.GetChild(0).gameObject.SetActive(false);
                    frames[3].SetActive(false);

                    frames[2].SetActive(true);
                    frames[2].transform.GetChild(0).gameObject.SetActive(false);
                    frames[2].transform.GetChild(1).gameObject.SetActive(false);
                    frames[2].transform.GetChild(2).gameObject.SetActive(true);
                }

                correct_option = 1;
                break;
            case 5:
                if (option == 1)
                {
                    frames[5].transform.GetChild(0).transform.GetChild(0).gameObject.SetActive(false);
                    frames[4].SetActive(false);

                    frames[6].SetActive(true);
                    frames[6].transform.GetChild(0).transform.GetChild(0).gameObject.SetActive(true);
                    frames[6].transform.GetChild(0).transform.GetChild(1).gameObject.SetActive(false);
                    frames[6].transform.GetChild(0).transform.GetChild(2).gameObject.SetActive(false);
                }
                else if (option == 2)
                {
                    frames[6].SetActive(false);
                    frames[4].SetActive(false);

                    frames[5].SetActive(true);
                    frames[5].transform.GetChild(0).transform.GetChild(0).gameObject.SetActive(true);
                    frames[5].transform.GetChild(0).transform.GetChild(1).gameObject.SetActive(true);
                    frames[5].transform.GetChild(0).transform.GetChild(2).gameObject.SetActive(false);
                }
                
                correct_option = 2;
                break;
            case 6:
                if (option == 1)
                {
                    frames[9].SetActive(false);
                    frames[8].SetActive(false);

                    frames[7].SetActive(true);
                    frames[7].transform.GetChild(0).transform.GetChild(0).gameObject.SetActive(true);
                    frames[7].transform.GetChild(0).transform.GetChild(1).gameObject.SetActive(true);
                    frames[7].transform.GetChild(0).transform.GetChild(2).gameObject.SetActive(false);
                }
                else if (option == 2)
                {
                    frames[7].transform.GetChild(0).transform.GetChild(0).gameObject.SetActive(false);
                    frames[9].SetActive(false);

                    frames[8].SetActive(true);
                    frames[8].transform.GetChild(0).transform.GetChild(0).gameObject.SetActive(true);
                    frames[8].transform.GetChild(0).transform.GetChild(1).gameObject.SetActive(false);
                    frames[8].transform.GetChild(0).transform.GetChild(2).gameObject.SetActive(false);
                }

                correct_option = 1;
                break;
            case 7:
                break;
            default:

                break;
        }
    }
}
