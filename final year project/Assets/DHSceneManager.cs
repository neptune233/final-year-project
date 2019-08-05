using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DHSceneManager : MonoBehaviour
{
    public void Introduction_Scene()
    {
        SceneManager.LoadScene(1);
    }

    public void Tutorial_Scene()
    {
        SceneManager.LoadScene(2);
    }

    public void Test_Scene()
    {
        SceneManager.LoadScene(3);
    }
}
