using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trail : MonoBehaviour {

    // Use this for initialization
    public TrailRenderer trail_x;
    public TrailRenderer trail_y;
    public TrailRenderer trail_z;

public void Cleartrail()
    {
        trail_x.Clear();
        trail_y.Clear();
        trail_z.Clear();
    }

}
