using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListaEnteros : MonoBehaviour
{
    List<int> L = new List<int>();
    public int N;
    // Start is called before the first frame update
    void Start()
    {
        L.Add(1);
        L.Add(2);
        L.Add(3);
        L.Add(4);
        L.Add(5);
        L.Add(6);
        L.Add(7);
        L.Add(8);
        L.Add(9);
        L.Add(10);

        Borrado();
    }

    // Update is called once per frame
    void Borrado()
    {
        if(N == 5)
        {
            L.Remove(5);
            
            foreach (int numeros in L)
            {
                Debug.Log(numeros);
            }
        }
        
    }
}
