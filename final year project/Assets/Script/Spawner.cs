using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class Spawner : MonoBehaviour
{
    public string coord_or_rotate;
    public Transform SpawnPos;
    public GameObject Cube;
    public GameObject Cylinder;
    public GameObject Sphere;
    public GameObject coordinate;
    public GameObject rotation;
    public Slider SliderInstance;
    public float slider_value;
    public RectTransform ListView;
    public GameObject List_Location;
    public GameObject Button_element;

    public Transform[] views;
    public float transitionSpeed;
    Transform currentView;

    private int model_index_count = 0;
    //public List<int> test = new List<int>();
    //private List<GameObject> model_list = new List<GameObject>();
    //public List<Vector3> model_translation = new List<Vector3>();
    //public List<Vector3> model_rotation = new List<Vector3>();
    private Vector3 offset = new Vector3(0f, -17.63546f, 0f);
    private int MoveDis = -130;

    private void Start()
    {
        //currentView = views[2];
    }

    public void Cubespawn()
    {
        GameObject new_cube = Instantiate(Cube, SpawnPos.position, SpawnPos.rotation);
        spawn_model(new_cube);
        //var cube_coordinate = Instantiate(coordinate, new_cube.transform.position - offset, new_cube.transform.rotation);
        //var cube_rotation = Instantiate(rotation, new_cube.transform.position, new_cube.transform.rotation);

        //cube_coordinate.transform.parent = new_cube.transform;
        //cube_coordinate.SetActive(false);
        //cube_rotation.transform.parent = new_cube.transform;
        //cube_rotation.SetActive(false);

        //new_cube.transform.name = model_index_count.ToString();
        //new_cube.GetComponent<GeoData>().index = model_index_count;
        //new_cube.GetComponent<GeoData>().Translation = new Vector3(new_cube.transform.position.x, new_cube.transform.position.y, new_cube.transform.position.z);
        //new_cube.GetComponent<GeoData>().Rotation = new Vector3(new_cube.transform.rotation.x, new_cube.transform.rotation.y, new_cube.transform.rotation.z);
        //var new_button = Instantiate(Button_element);
        //new_button.transform.parent = List_Location.transform;
        //new_button.transform.GetChild(0).GetChild(0).GetComponent<Text>().text = model_index_count.ToString();
        //model_index_count++;
    }

    public void CylinderSpawn()
    {
        GameObject new_cylinder = Instantiate(Cylinder, SpawnPos.position, SpawnPos.rotation);
        spawn_model(new_cylinder);
        //var cylinder_coordinate = Instantiate(coordinate, new_cylinder.transform.position - offset, new_cylinder.transform.rotation);
        //var cylinder_rotation = Instantiate(rotation, new_cylinder.transform.position, new_cylinder.transform.rotation);

        //cylinder_coordinate.transform.parent = new_cylinder.transform;
        //cylinder_coordinate.SetActive(false);
        //cylinder_rotation.transform.parent = new_cylinder.transform;
        //cylinder_rotation.SetActive(false);

        //new_cylinder.transform.name = model_index_count.ToString();
        //new_cylinder.GetComponent<GeoData>().index = model_index_count;
        //new_cylinder.GetComponent<GeoData>().Translation = new Vector3(new_cylinder.transform.position.x, new_cylinder.transform.position.y, new_cylinder.transform.position.z);
        //new_cylinder.GetComponent<GeoData>().Rotation = new Vector3(new_cylinder.transform.rotation.x, new_cylinder.transform.rotation.y, new_cylinder.transform.rotation.z);
        //var new_button = Instantiate(Button_element);
        //new_button.transform.parent = List_Location.transform;
        //new_button.transform.GetChild(0).GetChild(0).GetComponent<Text>().text = model_index_count.ToString();
        //model_index_count++;
    }

    public void SphereSpawn()
    {
        GameObject new_sphere = Instantiate(Sphere, SpawnPos.position, SpawnPos.rotation);
        spawn_model(new_sphere);
    }

    public void coordiante_edit()
    {
        coord_or_rotate = "coordinate";
    }

    public void rotation_edit()
    {
        coord_or_rotate = "rotation";
    }

    public void Slider_change(float new_value)
    {
        if (new_value != (float)0)
        {
            gameObject.GetComponent<Drag>().change_done = false;
            slider_value = new_value;
        }
    }

    public void Open_list()
    {
        ListView.DOAnchorPos(new Vector2(MoveDis - 30, 0), 0.25f);
        MoveDis = -MoveDis;
    }

    public void Destroy_model(Button btn)
    {
        string index = btn.transform.parent.GetChild(0).GetChild(0).GetComponent<Text>().text;
        Debug.Log(index);
        Destroy(GameObject.Find(index));
        Destroy(btn.transform.parent.gameObject);
    }

    public void McroEditingMode()
    {
        this.GetComponent<Drag>().micro_editing = !this.GetComponent<Drag>().micro_editing;
    }

    private void Update()
    {

        if (Input.GetMouseButtonUp(0))
        {
            gameObject.GetComponent<Drag>().change_done = true;
            SliderInstance.value = 0;
        }

    }

    private void spawn_model(GameObject model)
    {
        var cube_coordinate = Instantiate(coordinate, model.transform.position - offset, model.transform.rotation);
        var cube_rotation = Instantiate(rotation, model.transform.position, model.transform.rotation);

        cube_coordinate.transform.parent = model.transform;
        cube_coordinate.SetActive(false);
        cube_rotation.transform.parent = model.transform;
        cube_rotation.SetActive(false);

        model.transform.name = model_index_count.ToString();
        model.GetComponent<GeoData>().index = model_index_count;
        model.GetComponent<GeoData>().Translation = new Vector3(model.transform.position.x, model.transform.position.y, model.transform.position.z);
        model.GetComponent<GeoData>().Rotation = new Vector3(model.transform.rotation.x, model.transform.rotation.y, model.transform.rotation.z);
        var new_button = Instantiate(Button_element);
        new_button.transform.parent = List_Location.transform;
        new_button.transform.GetChild(0).GetChild(0).GetComponent<Text>().text = model_index_count.ToString();
        model_index_count++;
    }
}
