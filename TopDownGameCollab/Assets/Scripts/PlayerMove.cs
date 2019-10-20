using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMove : MonoBehaviour
{
    public float rotateSpeed = 2.0f;
    public float moveSpeed = 5.0f;
    Rigidbody2D rb;
    float startSpeed;
    float startRotSpeed;
    // Start is called before the first frame update
    void Awake()
    {
        startSpeed = moveSpeed;
        startRotSpeed = rotateSpeed;
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");
        transform.Rotate(new Vector3(0, 0, -x * rotateSpeed));
        GetComponent<Rigidbody2D>().velocity = y * transform.up * moveSpeed;
        GetComponent<Animator>().SetBool("move", y != 0);

    }
    public void EnableMovement()
    {
        rotateSpeed = startRotSpeed;
        moveSpeed = startSpeed;
    }
    public void DisableMovement()
    {
        rotateSpeed = 0;
        moveSpeed = 0;
    }
}
