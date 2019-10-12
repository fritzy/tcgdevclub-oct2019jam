using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSwitch : MonoBehaviour
{
    public List<GameObject> players;
    public int playerIndex = 0;
    // Start is called before the first frame update
    void Start()
    {
        players = new List<GameObject>();
        GameObject[] playerArray = GameObject.FindGameObjectsWithTag("Player");
        for(int i = 0; i < playerArray.Length; i++)
        {
            players.Add(playerArray[i]);
            if(i != 0)
            {
                players[i].GetComponent<PlayerMove>().DisableMovement();
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            players[playerIndex].GetComponent<PlayerMove>().DisableMovement();
            playerIndex++;
            playerIndex %= players.Count;
            players[playerIndex].GetComponent<PlayerMove>().EnableMovement();
        }
        Vector3 pos = players[playerIndex].transform.position;
        pos.z = transform.position.z;
        transform.position = Vector3.Lerp(transform.position, pos,5.0f*Time.deltaTime);
    }
    public void AddPlayer(GameObject player)
    {
        players.Add(player);
    }
}
