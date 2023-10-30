using System;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMover : MonoBehaviour
{
    [SerializeField] private List<Waypoint> _path = new();

    private void Start()
    {
        PrintWaypointName();
    }

    private void PrintWaypointName()
    {
        foreach (var waypoint in _path)
        {
            Debug.Log(waypoint.name);
        }
    }
}