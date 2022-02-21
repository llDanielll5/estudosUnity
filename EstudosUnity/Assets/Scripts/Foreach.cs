using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Foreach : MonoBehaviour
{
    string[] Inimigos = new string[3];
    void Start()
    {
        Inimigos[0] = "Morcego";
        Inimigos[1] = "Aranha";
        Inimigos[2] = "Slime";

        foreach (string i in Inimigos)
        {
            Debug.Log(i);
        }
    }

    void Update()
    {
        
    }
}
