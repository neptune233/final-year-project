using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DHTableCheck : MonoBehaviour
{
    public InputField[] DHtableElemente;
    public string[] Answer;

    public GameObject Error;
    public GameObject Correct;

    private bool check_flag;

    public void Check_btn()
    {
        check_flag = true;

        for (int i = 0; i <= DHtableElemente.Length; i ++)
        {
            if (DHtableElemente[i].text != Answer[i])
            {
                check_flag = false;
            }
        }

        if (check_flag)
        {
            Error.SetActive(false);
            Correct.SetActive(true);
        }
        else
        {
            Error.SetActive(true);
            Correct.SetActive(false);
        }
    }
}
