using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Metodos : MonoBehaviour
{
    public int Vida;
    void Start()
    {
        if(Vida == 100)
        {
            DiminuirVida(30);
        }
        else
        {
            AumentarVida(Vida);
        }
    }

    void Update()
    {
        
    }

    void AumentarVida(int life)
    {
        life++;
    }
    void DiminuirVida(int dano)
    {
        Vida -= dano;
    }
}
