using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
[SelectionBase]
[RequireComponent(typeof(Waypoint))]// if waypoint is not on game object add it it to object


public class CubeEditor : MonoBehaviour
{
    //[SerializeField] [Range (1f, 20f)] float gridSize = 10f;
   
    //TextMesh textMesh;
    GameObject GameObject;
    Waypoint waypoint;


    //Vector3 gridPos;
    float gridSize;
    // Start is called before the first frame update
    void Awake()
    {
        waypoint = GetComponent<Waypoint>();

    //    Debug.Log("editor coused this awake");
        gridSize = waypoint.GetGridSize();
    }


    // Update is called once per frame
    void Update()
    {
        //       Debug.Log("editor coused this update");
        snapToGrid();
        UpdateLable(new Vector3(
            waypoint.GetGridPosV3().x*waypoint.GetGridSize(),
            waypoint.GetGridPosV3().y*waypoint.GetGridSize(),
            waypoint.GetGridPosV3().z*waypoint.GetGridSize()

            ));
    }

    private void snapToGrid()
    {
        //gridPos.x = Mathf.RoundToInt(transform.position.x / gridSize) * gridSize;
        //      Debug.Log(snapPos.x);

        //gridPos.y = Mathf.RoundToInt(transform.position.y /gridSize) *gridSize;
        //       Debug.Log(snapPos.y);

        //gridPos.z = Mathf.RoundToInt(transform.position.z /gridSize) *gridSize;
        //      Debug.Log(snapPos.z);
        this.transform.position = new Vector3(
            waypoint.GetGridPosV3().x*waypoint.GetGridSize(), 
            waypoint.GetGridPosV3().y*waypoint.GetGridSize(), 
            waypoint.GetGridPosV3().z*waypoint.GetGridSize()
            );
        print(waypoint.GetGridSize());
    }

    private void UpdateLable(Vector3 gridPos)
    {
        TextMesh textMesh = GetComponentInChildren<TextMesh>();
        string labelText = gridPos.x /gridSize + "," + gridPos.z /gridSize;
        textMesh.text = labelText;
        this.gameObject.name = "cube " + labelText;
    }
}
