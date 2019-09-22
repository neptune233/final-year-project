using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trail : MonoBehaviour {
    
    // Use this for initialization
    public TrailRenderer trail_x;
    public TrailRenderer trail_y;
    public TrailRenderer trail_z;
    public TrailRenderer trail_x_ans;
    public TrailRenderer trail_y_ans;
    public TrailRenderer trail_z_ans;
    public GameObject UserxRef;
    public GameObject UseryRef;
    public GameObject UserzRef;
    public GameObject AnsxRef;
    public GameObject AnsyRef;
    public GameObject AnszRef;
    public GameObject User;

    public void Cleartrail()
    {
        trail_x.Clear();
        trail_y.Clear();
        trail_z.Clear();
        trail_x_ans.Clear();
        trail_y_ans.Clear();
        trail_z_ans.Clear();
    }

    public void Refenable()
    {
        UserxRef.SetActive(true);
        UseryRef.SetActive(true);
        UserzRef.SetActive(true);
        AnsxRef.SetActive(true);
        AnsyRef.SetActive(true);
        AnszRef.SetActive(true);
    }

    public void Returntostartposition()
    {
        User.transform.localRotation = new Quaternion(0, 0, 0, 0);
        if (GameObject.Find("ref1"))
        {
            Destroy(GameObject.Find("ref1"));
        }
        if (GameObject.Find("ref2"))
        {
            Destroy(GameObject.Find("ref2"));
        }
        if (GameObject.Find("ref3"))
        {
            Destroy(GameObject.Find("ref3"));
        }
        Buttonid.Step = 0;
        Quiz.Iscreated1 = true;
        Quiz.Iscreated2 = true;
        Quiz.Iscreated3 = true;
        Quiz.Timer1 = 0;
        Quiz.Timer2 = 0;

    }
}
