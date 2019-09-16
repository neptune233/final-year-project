using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DHTable : MonoBehaviour
{
    
    public void OninputfieldClick ()
    {
        //Debug.Log(this.gameObject.name);
        GameObject.Find("keyboard").GetComponent<Keyboard>().current_inputfield = int.Parse(this.gameObject.name);
   
    }

   
}
