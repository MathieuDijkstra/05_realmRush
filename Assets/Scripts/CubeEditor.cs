using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
[SelectionBase]
public class CubeEditor : MonoBehaviour
{
    [SerializeField] [Range (1f, 20f)] float gridSize = 10f;
    TextMesh textMesh;
    GameObject GameObject;
    // Start is called before the first frame update
    void Awake()
    {
        Debug.Log("editor coused this awake");
    }

    private void Start()
    {



    }
    // Update is called once per frame
    void Update()
    {

 //       Debug.Log("editor coused this update");
        Vector3 snapPos;
        snapPos.x = Mathf.RoundToInt(transform.position.x /gridSize) * gridSize;
  //      Debug.Log(snapPos.x);

        snapPos.y = Mathf.RoundToInt(transform.position.y / gridSize) * gridSize;
 //       Debug.Log(snapPos.y);

        snapPos.z = Mathf.RoundToInt(transform.position.z / gridSize) * gridSize;
  //      Debug.Log(snapPos.z);
        this.transform.position = new Vector3(snapPos.x, snapPos.y, snapPos.z);
        textMesh = GetComponentInChildren<TextMesh>();
        string labelText = snapPos.x/gridSize+","+snapPos.z/gridSize;
        textMesh.text = labelText;
        this.gameObject.name = "cube "+labelText;
    }
}
