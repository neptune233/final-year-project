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

}
