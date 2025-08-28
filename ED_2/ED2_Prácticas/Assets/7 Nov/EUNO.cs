using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EUNO : MonoBehaviour
{
    private int numero;
    // Start is called before the first frame update
    void Start()
    {
        for(numero = 0; numero <= 30; numero++)
        {
            if(numero % 2 == 0)
            {
                Debug.Log(numero);
            }
            
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
