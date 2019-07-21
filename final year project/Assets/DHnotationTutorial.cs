using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DHnotationTutorial : MonoBehaviour
{
    public GameObject[] views;
    public GameObject[] frames;
    public int progress_stage;
    public int option_stage;
    public int option;

    // Start is called before the first frame update
    void Start()
    {
        progress_stage = 0;
        option_stage = 0;
        option = 0;
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
                break;
            case 3:
                views[0].SetActive(false);
                views[1].SetActive(false);
                views[2].SetActive(true);
                option_stage = 1;
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

        switch (option_stage)
        {
            case 1:
               
                break;
            case 2:
                
                break;
            case 3:
                
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
                
                break;
        }

        switch (option)
        {
            case 1:

                break;
            case 2:

                break;
            case 3:

                break;
            default:

                break;
        }
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
        option_stage += 1;
    }
}
