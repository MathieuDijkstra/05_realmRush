using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMover : MonoBehaviour
{
    [SerializeField] List<Block> path ;
    // Start is called before the first frame update
    void Start()
    {
        PrintAllWayPoints();
    }

    private void PrintAllWayPoints()
    {
        foreach (Block var in path)
        {
            print(var.name);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
