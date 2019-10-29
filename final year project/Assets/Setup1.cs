using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Setup1 : MonoBehaviour
{

    
    public GameObject Userx;
    public GameObject Usery;
    public GameObject Userz;

    public Transform Cam;       // Position information of the camera
  

    public Transform Userxcoor; // Position information of x text in user coordinate
    public Transform Userycoor; // Position information of y text in user coordinate
    public Transform Userzcoor; // Position information of z text in user coordinate

    
   



    private void Update()
    {

        Quaternion lastRotation = Cam.rotation;

        
        Userx.transform.rotation = lastRotation;
        Usery.transform.rotation = lastRotation;
        Userz.transform.rotation = lastRotation;
        Userx.transform.position = Userxcoor.position;
        Usery.transform.position = Userycoor.position;
        Userz.transform.position = Userzcoor.position;

    }

    

}




