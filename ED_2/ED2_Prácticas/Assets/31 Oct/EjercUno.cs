using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjercUno : MonoBehaviour
{
    public int numero;
    // Start is called before the first frame update
    void Start()
    {
        if(numero % 2 == 0)
        {
            Debug.Log("Es par");
        }

        else
        {
            Debug.Log("Es impar");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
