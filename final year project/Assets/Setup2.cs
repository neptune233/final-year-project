using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Setup2 : MonoBehaviour {
    
    public GameObject Ansx;
    public GameObject Ansy;
    public GameObject Ansz;
    public GameObject Userx;
    public GameObject Usery;
    public GameObject Userz;

    public Transform Cam;       // Position information of the camera
    public Transform Ansxcoor;  // Position information of x text in answer coordinate
    public Transform Ansycoor;  // Position information of y text in answer coordinate
    public Transform Anszcoor;  // Position information of z text in answer coordinate

    public Transform Userxcoor; // Position information of x text in user coordinate
    public Transform Userycoor; // Position information of y text in user coordinate
    public Transform Userzcoor; // Position information of z text in user coordinate

    public GameObject[] Matrix;
    public Sprite HighlightImage;
    public Sprite NormalImage;

    public GameObject Board;

    // Use this for initialization
    void Start() {
         
    }


    private void Update()
    {

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

        

            if ((Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began) || Input.GetMouseButtonDown(0))
           {
                if (EventSystem.current.currentSelectedGameObject == null)
                {

                    Board.SetActive(false);


                }


                if (EventSystem.current.currentSelectedGameObject != null)
                {


                    if (EventSystem.current.currentSelectedGameObject.tag.ToString() == "Input")
                    {
                        Board.SetActive(true);

                    }
                    else
                    {
                        Board.SetActive(false);

                    }
                }
        }



        for (int i = 0; i < 32; i++)
        {
            if (GameObject.Find("keyboard") == true)
            {
                if (i != GameObject.Find("keyboard").GetComponent<Keyboard>().current_inputfield)
                {
                    Matrix[i].transform.localScale = new Vector3(2.1333f, 2.1333f, 2.1333f);
                    Matrix[i].GetComponent<Image>().sprite = NormalImage;

                }
                else
                {
                    Matrix[i].transform.localScale = new Vector3(2.5f, 2.5f, 2.5f);
                    Matrix[i].GetComponent<Image>().sprite = HighlightImage;
                }
            }
        }
    }


     }




