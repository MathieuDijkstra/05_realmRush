using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class EditorSnap : MonoBehaviour
{
    // Start is called before the first frame update
    void Awake()
    {
        Debug.Log("editor coused this awake");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("editor coused this update");
        Vector3 snapPos;
        snapPos.x = Mathf.RoundToInt(transform.position.x / 10f) * 10;
        Debug.Log(snapPos.x);

        snapPos.y = Mathf.RoundToInt(transform.position.y / 10f) * 10;
        Debug.Log(snapPos.y);

        snapPos.z = Mathf.RoundToInt(transform.position.z / 10f) * 10;
        Debug.Log(snapPos.z);
        this.transform.position = new Vector3(snapPos.x, snapPos.y, snapPos.z);
    }
}
