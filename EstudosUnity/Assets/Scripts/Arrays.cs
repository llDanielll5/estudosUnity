using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrays : MonoBehaviour
{
    GameObject[] Player;
    void Start()
    {
        Player = GameObject.FindGameObjectsWithTag("Player");
        foreach(GameObject p in Player)
        {
            Debug.Log(p.name);
        }
    }

    void Update()
    {
        
    }
}
