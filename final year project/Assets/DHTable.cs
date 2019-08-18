using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DHTable : MonoBehaviour
{
    public int Selected_Index;
    public string Answer;
    public string Selected_axis;

    public void DHTable_btn(string answer)
    {
        Answer = answer;
    }

    private void Update()
    {
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out hit))
        {
            
            if (hit.collider.gameObject.tag == "Axis")
            {
                Selected_axis = hit.collider.gameObject.name;
            }

            
        }
    }
}
