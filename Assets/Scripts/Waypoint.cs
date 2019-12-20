using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waypoint : MonoBehaviour
{
    Vector2Int gridPos;
    const float gridSize = 10.0f;
    // Start is called before the first frame update

    public float GetGridSize() 
    {
        return gridSize;
    }
    public Vector3 GetGridPosV3() 
    {
       
        //      Debug.Log(snapPos.x);

  
        //       Debug.Log(snapPos.y);


        //      Debug.Log(snapPos.z);
        return new Vector3(
             Mathf.RoundToInt(transform.position.x) ,
             Mathf.RoundToInt(transform.position.y) ,
             Mathf.RoundToInt(transform.position.z) 
            );
    }

    public void SetTopColor(Color color) 
    {
        MeshRenderer cubeTopMeshRenderer=transform.Find("cubetop").GetComponent<MeshRenderer>();
        cubeTopMeshRenderer.material.color = color;
    }

}
