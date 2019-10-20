using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;

public class ToggleFollowHuman : MonoBehaviour
{
    public bool followHuman = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetAxis("FollowHuman").Equals(1) && Camera.main.GetComponent<PlayerSwitch>().CurrentPlayer().Equals(gameObject))
        {
            followHuman = true;
        }
        if((Input.GetAxis("Horizontal") != 0 || Input.GetAxis("Vertical") != 0) && Camera.main.GetComponent<PlayerSwitch>().CurrentPlayer().Equals(gameObject))
        {
            followHuman = false;
        }
        if (followHuman)
        {
            GetComponent<AIPath>().enabled = true;
            GetComponent<AIDestinationSetter>().enabled = true;
            GetComponent<AIDestinationSetter>().target = GameObject.Find("Human").transform;
        }
        else
        {
            GetComponent<AIPath>().enabled = false;
            GetComponent<AIDestinationSetter>().enabled = false;
        }
    }
}
