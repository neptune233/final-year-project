using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Reset : MonoBehaviour {
public void OnClick()
    {
        SceneManager.LoadScene("Index");
        MoveObject.Newposition1 = new Vector3(0, 0.3f, 0);
        MoveObject.Newposition2 = new Vector3(0, 0.3f, 0);
        MoveObject.Newposition3 = new Vector3(0, 0.3f, 0);
        MoveObject.Newposition4 = new Vector3(0, 0.3f, 0);
        MoveObejct_Directly.Newposition1 = new Vector3(0,0.3f,0);
        MoveObejct_Directly.Newposition2 = new Vector3(0, 0.3f, 0);
        MoveObejct_Directly.Newposition3 = new Vector3(0, 0.3f, 0);
        MoveObejct_Directly.Newposition4 = new Vector3(0, 0.3f, 0);

    }
    public void Skip()
    {
        SceneManager.LoadScene("Index");
    }
}
