using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Introduction : MonoBehaviour
{
    public GameObject[] MainScene;
    public GameObject[] IntroScene;
    public GameObject[] InstructionScene;
    public GameObject Instruction;

    public int MainScene_counter = 0;
    public int IntroScene_counter = 0;
    public int InstructionScene_counter = 0;

    public int IntroSceneMax = 2;
    private int InstructionSceneMax = 2;

    public void Next_Btn()
    {
        IntroScene_counter += 1;
    }

    public void Okay_btn()
    {
        InstructionScene_counter += 1;
    }

    public void Information_btn()
    {
        Instruction.SetActive(true);
    }

    private void Start()
    {
        Instruction.SetActive(true);
    }

    private void Update()
    {
        if(MainScene_counter == 0)
        {
            MainScene[0].SetActive(true);
            MainScene[1].SetActive(false);
        }
        else if(MainScene_counter == 1)
        {
            MainScene[0].SetActive(false);
            MainScene[1].SetActive(true);
        }

        if (IntroScene_counter > IntroSceneMax)
        {
            MainScene_counter = 1;
        }

        for (int i = 0; i <= IntroSceneMax; i ++)
        {
            if (i != IntroScene_counter)
            {
                IntroScene[i].SetActive(false);
            }
            else if(i == IntroScene_counter)
            {
                IntroScene[i].SetActive(true);
            }
        }

        if (InstructionScene_counter > InstructionSceneMax)
        {
            InstructionScene_counter = 0;
            Instruction.SetActive(false);
        }

        for (int i = 0; i <= InstructionSceneMax; i ++)
        {
            if (i != InstructionScene_counter)
            {
                InstructionScene[i].SetActive(false);
            }
            else if(i == InstructionScene_counter)
            {
                InstructionScene[i].SetActive(true);
            }
        }
    }
}
