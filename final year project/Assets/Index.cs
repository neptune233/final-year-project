using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Index : MonoBehaviour
{
    
    public void Scene_1()
    {
        SceneManager.LoadScene("1");
    }

    public void Scene_2()
    {
        SceneManager.LoadScene("2");
    }

    public void Scene_3()
    {
       SceneManager.LoadScene("3");
    }
}
