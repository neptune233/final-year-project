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

   
    public Color a;

    public GameObject Ansx;
    public GameObject Ansy;
    public GameObject Ansz;
    public GameObject Userx;
    public GameObject Usery;
    public GameObject Userz;

    public Transform Cam;
    public Transform Ansxcoor;
    public Transform Ansycoor;
    public Transform Anszcoor;

    public Transform Userxcoor;
    public Transform Userycoor;
    public Transform Userzcoor;
    // Use this for initialization
    void Start() {
        ref_1_x.GetComponent<MeshRenderer>().material.color = Color.black;
        ref_1_z.GetComponent<MeshRenderer>().material.color = Color.black;
        ref_2_y.GetComponent<MeshRenderer>().material.color = Color.black;
        ref_2_z.GetComponent<MeshRenderer>().material.color = Color.black;
        ref_3_x.GetComponent<MeshRenderer>().material.color = Color.black;
        ref_3_y.GetComponent<MeshRenderer>().material.color = Color.black;


    
      
       
        
    }


    private void Update()
    {
        /*
        x.transform.rotation = new Quaternion(0, 0, 0, 1);
        y.transform.rotation = new Quaternion(0, 0, 0, 1);
        z.transform.rotation = new Quaternion(0, 0, 0, 1);
        */
        Quaternion lastRotation = Cam.rotation;

        Ansx.transform.rotation = lastRotation;
        Ansy.transform.rotation = lastRotation;
        Ansz.transform.rotation = lastRotation;
        Ansx.transform.position = Ansxcoor.position;
        Ansy.transform.position = Ansycoor.position;
        Ansz.transform.position = Anszcoor.position;
        Userx.transform.rotation = lastRotation;
        Usery.transform.rotation = lastRotation;
        Userz.transform.rotation = lastRotation;
        Userx.transform.position = Userxcoor.position;
        Usery.transform.position = Userycoor.position;
        Userz.transform.position = Userzcoor.position;



    }


}
