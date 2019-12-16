using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathFinder : MonoBehaviour
{
    Dictionary<Vector3, Waypoint> grid = new Dictionary<Vector3, Waypoint>();
    [SerializeField] Waypoint StartWaypoint, EndWaypoint;
    // Start is called before the first frame update
    void Start()
    {

        LoadBlocks();
        StartWaypoint.SetTopColor(Color.green);
        EndWaypoint.SetTopColor(Color.red);
    }

    private void LoadBlocks()
    {
        
        Waypoint[] waypoints = FindObjectsOfType<Waypoint>();// must get all objects
        foreach(Waypoint pointerWaypoints in waypoints) 
        {
            bool isoverlapping = grid.ContainsKey(pointerWaypoints.GetGridPosV3());
            if (isoverlapping)
            {
                Debug.LogWarning("skipping overlapping block : " + pointerWaypoints);
            }
            else
            {
                grid.Add(pointerWaypoints.GetGridPosV3(), pointerWaypoints);
                pointerWaypoints.SetTopColor(Color.black);
            }
        }
        print(grid.Count);
    }
}
