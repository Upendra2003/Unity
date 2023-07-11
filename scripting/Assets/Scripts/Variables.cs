using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Variables : MonoBehaviour
{
    int health = 5;
    float speed = 0.5f;
    string charName = "Player 1";

    private void Start()
    {
        print(health);
        print(speed);
        print("This is " + charName);
    }

    private void Update()
    {
        //print(health);
    }
}
