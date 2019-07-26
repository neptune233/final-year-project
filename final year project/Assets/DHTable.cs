using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DHTable : MonoBehaviour
{
    public void OninputfieldClick ()
    {
        GameObject.Find("keyboard").GetComponent<Keyboard>().current_inputfield = int.Parse(this.gameObject.name);
    }

   
}
