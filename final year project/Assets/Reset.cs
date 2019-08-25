using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Reset : MonoBehaviour {
public void OnClick()
    {
        SceneManager.LoadScene("Index");
        MoveObject_Matrix.Newposition1 = new Vector3(0, 0.2f, -0.3f);
        MoveObject_Matrix.Newposition2 = new Vector3(0, 0.2f, -0.3f);
        MoveObject_Matrix.Newposition3 = new Vector3(0, 0.2f, -0.3f);
        MoveObject_Matrix.Newposition4 = new Vector3(0, 0.2f, -0.3f);
        MoveObejct_Directly.Newposition1 = new Vector3(0, 0.2f, -0.3f);
        MoveObejct_Directly.Newposition2 = new Vector3(0, 0.2f, -0.3f);
        MoveObejct_Directly.Newposition3 = new Vector3(0, 0.2f, -0.3f);
        MoveObejct_Directly.Newposition4 = new Vector3(0, 0.2f, -0.3f);

    }
    public void Exercise1()
    {
        SceneManager.LoadScene("2_1");
    }

   
}
