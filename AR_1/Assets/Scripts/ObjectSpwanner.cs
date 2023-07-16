using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpwanner : MonoBehaviour
{
    public GameObject objectToSpwan;
    private PlacementIndicator placementIndicator;

    private void Start()
    {
        placementIndicator = FindObjectOfType<PlacementIndicator>();
    }

    private void Update()
    {
        if(Input.touchCount >0 && Input.touches[0].phase == TouchPhase.Began)
        {
            GameObject obj = Instantiate(objectToSpwan, placementIndicator.transform.position,placementIndicator.transform.rotation);

        }
    }
}
