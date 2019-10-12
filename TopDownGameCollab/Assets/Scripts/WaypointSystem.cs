using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaypointSystem : MonoBehaviour
{
    [Tooltip("Enables looping for waypoints")]
    public bool loop = true;

    public List<GameObject> waypoints;
   
}
