using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaypointSystem : MonoBehaviour
{
    [Tooltip("Adjust the speed of the entity here.")]
    public float speed;
    private float waitTime;

    [Tooltip("Set the amount of time it take for the entity to wait before it moves. Note: Smaller values are better.")]
    public float startWaitTime;
    
    [Tooltip("Enables random partol for entity.")]
    public bool random;

    [Tooltip("Enables looping of waypoints.")]
    public bool loop;

    [Tooltip("Set the amount of waypoints for the entity to follow. Drag and drop waypoints(empty gameobjects) into each slot.")]
    public Transform[] Waypoints;

    public int waypointIndex = 0;
    private int randomSpot;
    
    

    void Start()
    {
        waitTime = startWaitTime;
        transform.position = Waypoints[waypointIndex].transform.position;
        randomSpot = Random.Range(0, Waypoints.Length);
        
    }

    void Update()
    {

        if (random == false)
        {
            
            transform.position = Vector2.MoveTowards(transform.position, Waypoints[waypointIndex].transform.position, speed * Time.deltaTime);
            

            if (transform.position == Waypoints[waypointIndex].transform.position)
            {
                waypointIndex += 1;
                Debug.Log(waypointIndex);
            }

            if (waypointIndex == Waypoints.Length)
            {
                waypointIndex = 0;
            }

        }
        else
        {
        transform.position = Vector2.MoveTowards(transform.position, Waypoints[randomSpot].position, speed * Time.deltaTime);

            if(Vector2.Distance(transform.position, Waypoints[randomSpot].position) < 0.2f)
            {
                if(waitTime <= 0)
                {
                    randomSpot = Random.Range(0, Waypoints.Length);
                    waitTime = startWaitTime;
                }
                else
                {
                    waitTime -= Time.deltaTime;
                }
            }
        }
        
    }
}
