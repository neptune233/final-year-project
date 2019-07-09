using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colour : MonoBehaviour {
    public GameObject ref_1_x;
    public GameObject ref_1_z;
    public GameObject ref_2_y;
    public GameObject ref_2_z;
    public GameObject ref_3_x;
    public GameObject ref_3_y;



    public GameObject orgin;
    public GameObject xx;
    public GameObject yy;
    public GameObject zz;
    public GameObject point;
    public GameObject vector;
    public Color a;
    // Use this for initialization
    void Start() {
        ref_1_x.GetComponent<MeshRenderer>().material.color = Color.black;
        ref_1_z.GetComponent<MeshRenderer>().material.color = Color.black;
        ref_2_y.GetComponent<MeshRenderer>().material.color = Color.black;
        ref_2_z.GetComponent<MeshRenderer>().material.color = Color.black;
        ref_3_x.GetComponent<MeshRenderer>().material.color = Color.black;
        ref_3_y.GetComponent<MeshRenderer>().material.color = Color.black;


        xx.GetComponent<MeshRenderer>().material.color = Color.red;
        yy.GetComponent<MeshRenderer>().material.color = Color.green;
        zz.GetComponent<MeshRenderer>().material.color = Color.blue;
        orgin.GetComponent<MeshRenderer>().material.color = Color.black;
        point.GetComponent<MeshRenderer>().material.color = a;
        vector.GetComponent<MeshRenderer>().material.color = a;
    }
		
	
	
	// Update is called once per frame
	void Update () {
		
	}
}
