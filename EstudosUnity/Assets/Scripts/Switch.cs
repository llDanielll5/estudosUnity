using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour
{
    public int DiaSemana;

    void Start()
    {
        switch (DiaSemana)
        {
            case 1:
                Debug.Log("Domingo");
                break;
            case 2:
                Debug.Log("Segunda-Feira");
                break;
            case 3:
                Debug.Log("Terça-Feira");
                break;
            case 4:
                Debug.Log("Quarta-Feira");
                break;
            case 5:
                Debug.Log("Quinta-Feira");
                break;
            case 6:
                Debug.Log("Sexta-Feira");
                break;
            case 7:
                Debug.Log("Sábado");
                break;
            default:
                Debug.Log("Dia incorreto!");
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
