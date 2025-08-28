using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjercDos : MonoBehaviour
{
    public float n;
    // Start is called before the first frame update
    void Start()
    {
        if (n % 2 == 0)
        {
            Debug.Log("Es un decimal PAR");
        }

        else
        {
            Debug.Log("Es un decimal impar");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
