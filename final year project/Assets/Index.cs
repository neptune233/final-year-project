using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Index : MonoBehaviour
{
    
    public void Samplequestion()
    {
        SceneManager.LoadScene("Samplequestion");
    }

    public void Moreexercise()
    {
        SceneManager.LoadScene("Moreexercise");
    }

    public void Mainmenu()
    {
       SceneManager.LoadScene("Index");
    }

    public void Transformationmatrix()
    {
        SceneManager.LoadScene("Transformationmatrix");
    }
}
