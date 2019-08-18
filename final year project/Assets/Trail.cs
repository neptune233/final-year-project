using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trail : MonoBehaviour {

    // Use this for initialization
    public TrailRenderer trail_x;
    public TrailRenderer trail_y;
    public TrailRenderer trail_z;
    public TrailRenderer trail_xx;
    public TrailRenderer trail_yy;
    public TrailRenderer trail_zz;
    public GameObject UserxRef;
    public GameObject UseryRef;
    public GameObject UserzRef;

    public void Cleartrail()
    {
        trail_x.Clear();
        trail_y.Clear();
        trail_z.Clear();
        //trail_xx.Clear();
        //trail_yy.Clear();
        //trail_zz.Clear();
    }

    public void Refenable()
    {
        UserxRef.SetActive(true);
        UseryRef.SetActive(true);
        UserzRef.SetActive(true);
    }

}
