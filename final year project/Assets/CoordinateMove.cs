using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoordinateMove : MonoBehaviour
{
  
    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out hit))
        {
            if (hit.transform != null)
            {
                if (hit.transform.name == "x-axis" || hit.transform.name == "y-axis" || hit.transform.name == "z-axis")
                {
                    Debug.Log("xyz");
                }
                Debug.Log("HIT");
            }

        }
    }
}
