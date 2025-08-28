using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pila : MonoBehaviour
{
    public int P;
    public int V;
    public int N;
    // Start is called before the first frame update
    void Start()
    {
        if(N > V)
        {
            Reemplazar();
        }

        if(N < V)
        {
            Inverso();
        }

        if(N == P)
        {
            Igual();
        }

        if(N > P)
        {
            Fuera();
        }
    }

    // Update is called once per frame
    void Reemplazar()
    {
        Debug.Log("Esta en la pila:" + N);
    }

    void Inverso()
    {
        Debug.Log("Esta en la pila:" + V);
    }

    void Igual()
    {
        Debug.Log("Es igual a la pila:" + P);
    }

    void Fuera()
    {
        Debug.Log("Esta fuera de la pila:" + N);
    }
}
