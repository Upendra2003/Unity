using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public GameObject player;
    public Camera getcamera;
    public Vector3 offset;

    // Update is called once per frame
    void Update()
    {
        getcamera.transform.position = player.transform.position + offset;
    }
}
