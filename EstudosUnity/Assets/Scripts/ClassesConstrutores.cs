using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClassesConstrutores : MonoBehaviour
{
    [System.Serializable]
    public class Cachorro
    {
        public string raca;
        public int idade;
        public int tamanho;

        public Cachorro(string _raca, int _idade, int _tamanho)
        {
            raca = _raca;
            idade = _idade;
            tamanho = _tamanho;
        }
    }

    public Cachorro Dog = new Cachorro("Shit-zu", 10, 2);

    private void Start()
    {
        Debug.Log(Dog.raca);
    }
}
