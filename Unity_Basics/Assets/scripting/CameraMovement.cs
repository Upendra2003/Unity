using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public Camera cameraComponent;
    public float zoomSpeed;
    void Start()
    {
        
    }

    
    void Update()
    {
        if (Input.GetKey(KeyCode.E))
        {
            cameraComponent.orthographicSize += zoomSpeed;
        }
        if (Input.GetKey(KeyCode.Q))
        {
            cameraComponent.orthographicSize -= zoomSpeed;
        }
    }
}
