using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PruebaE1 : MonoBehaviour
{
    public int pila = 3;
    public int nuevo = 2;
    public int viejo = 1;

    // Start is called before the first frame update
    void Start()
    {
        if(nuevo == 2 || viejo == 1)
        {
            Debug.Log(nuevo);
        }
        else
        {
            pila = nuevo;
            Debug.Log(pila);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
