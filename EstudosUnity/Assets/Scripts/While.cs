using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class While : MonoBehaviour
{
    int ItensCena = 5;
    int dinheiro = 500;
    void Start()
    {
        //while (ItensCena > 0)
        //{
        //    Debug.Log("peguei item!");
        //    ItensCena--;
        //}
        do
        {
            Debug.Log("A sua grana é: " + dinheiro);
            dinheiro += 50;
        }
        while (dinheiro < 1000);
    }

    void Update()
    {
        
    }
}
