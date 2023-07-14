using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rigidBody;
    public float playerSpeed=2000f;
    public float sideSpeed = 500f;

    void Update()
    {
        rigidBody.AddForce(0, 0, playerSpeed * Time.deltaTime);

        if (Input.GetKey("d"))
        {
            rigidBody.AddForce(sideSpeed*Time.deltaTime, 0, 0,ForceMode.VelocityChange);
        }

        if (Input.GetKey("a"))
        {
            rigidBody.AddForce(-sideSpeed*Time.deltaTime, 0, 0,ForceMode.VelocityChange);
        }

        if(rigidBody.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }

    }
}
