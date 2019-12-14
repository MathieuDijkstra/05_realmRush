using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMover : MonoBehaviour
{
    [SerializeField] List<Waypoint> path ;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(FolowPath());
        print("hi");
    }

    //
    // this is the corotine caled with StartCoroutine(PrintAllWayPoints());
    //
    IEnumerator FolowPath()
    {
        Debug.Log("starting patrol");
        foreach (Waypoint var in path)
        {
            print("visiting block"+var.name);
            this.transform.position = var.transform.position;
            yield return new WaitForSeconds(1f);// wacht 1 seconde
        }
        Debug.Log("ending patrol");
    }


}
