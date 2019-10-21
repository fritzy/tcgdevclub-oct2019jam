using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivatePet : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag.Equals("Player") && !GetComponent<PlayerMove>().enabled)
        {
            GetComponent<PlayerMove>().enabled = true;
            GetComponent<ActivatePet>().enabled = false;
            Camera.main.GetComponent<PlayerSwitch>().AddPlayer(gameObject);
            gameObject.tag = "Player";
        }
    }
}
