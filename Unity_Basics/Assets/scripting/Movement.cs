using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float xSpeed;
    public float ySpeed;

    public bool isMovingLeft;
    public bool isMovingRight;
    public bool isMovingUp;
    public bool isMovingDown;


    void Update()
    {
        if (isMovingRight)
        {
            transform.position += new Vector3(xSpeed, 0, 0);
        }
        if (isMovingLeft)
        {
            transform.position += new Vector3(-xSpeed, 0, 0);
        }
        if (isMovingUp)
        {
            transform.position += new Vector3(0, ySpeed, 0);
        }
        if (isMovingDown)
        {
            transform.position += new Vector3(0, -ySpeed, 0);
        }
    }

    public void TriggerLeft(bool canMove)
    {
        isMovingLeft = canMove;
    }

    public void TriggerRight(bool canMove)
    {
        isMovingRight = canMove;
    }

    public void TriggerUp(bool canMove)
    {
        isMovingUp = canMove;
    }

    public void TriggerDown(bool canMove)
    {
        isMovingDown = canMove;
    }

    /*public void moveUp()
    {
        transform.position += new Vector3(0, ySpeed, 0);
    }

    public void moveDown()
    {
        transform.position += new Vector3(0, -ySpeed, 0);
    }

    public void moveRight()
    {
        transform.position += new Vector3(xSpeed, 0, 0);
    }

    public void moveLeft()
    {
        transform.position += new Vector3(-xSpeed, 0, 0);
    }*/
}
