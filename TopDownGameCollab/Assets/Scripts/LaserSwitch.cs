using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserSwitch : MonoBehaviour
{
    [Tooltip("Drag the laser object from the hierarchy that this switch will destroy")]
    public GameObject lasers;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<Flags>() != null)
        {
            if (collision.gameObject.GetComponent<Flags>().ability.ToString().Equals("FlipSwitches") && Input.GetAxis("Ability").Equals(1))
            {
                lasers.active = false;
            }
        }
    }
}
