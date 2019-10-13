using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaypointSystem : MonoBehaviour
{
    [Tooltip("Enables looping for waypoints")]
    public bool loop = true;

    [Tooltip("Add or remove waypoints by increasing or decreasing the size value")]
    public List<GameObject> waypoints;


   
}
