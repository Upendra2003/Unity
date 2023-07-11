using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Functions : MonoBehaviour
{
    //public int MaxHealth = 100;
    //int health;
    string[] myArray = new string[3] { "one", "two", "three" };
    // Start is called before the first frame update
    void Start()
    {
        /*if (19 > 18)
        {
            health=increaseHealth(10);
        }
        print(health);*/
        foreach(string name in myArray)
        {
            print(name);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /*int increaseHealth(int Health)
    {
        MaxHealth += Health;
        return MaxHealth;
    }*/
}
