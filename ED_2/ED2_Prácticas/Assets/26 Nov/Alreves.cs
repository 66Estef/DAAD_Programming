using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Alreves : MonoBehaviour
{
    List<int> lista = new List<int>();
    // Start is called before the first frame update
    void Start()
    {
        lista.Add(99);
        lista.Add(101);
        lista.Add(105);
        lista.Add(111);
        lista.Add(117);
        lista.Add(121);
        lista.Add(124);

        Inverso();
    }

    // Update is called once per frame
    void Inverso()
    {
        lista.Reverse();
        foreach (int l in lista)
        {
            Debug.Log(l);
        }
    }
}
