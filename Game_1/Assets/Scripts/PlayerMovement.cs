using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rigidBody;
    public float playerSpeed=2000f;
    public float sideSpeed = 500f;

    void FixedUpdate()
    {
        rigidBody.AddForce(0, 0, playerSpeed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.D))
        {
            rigidBody.AddForce(sideSpeed, 0, 0);
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            rigidBody.AddForce(-sideSpeed, 0, 0);
        }

    }
}
