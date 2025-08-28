using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MezclaListas : MonoBehaviour
{
    List<int> Lista1 = new List<int>();
    List<int> Lista2 = new List<int>();
    // Start is called before the first frame update
    void Start()
    {
        Lista1.Add(21);
        Lista1.Add(22);
        Lista1.Add(23);
        Lista1.Add(24);
        Lista1.Add(25);
        Lista1.Add(26);

        Lista2.Add(42);
        Lista2.Add(43);
        Lista2.Add(44);
        Lista2.Add(45);
        Lista2.Add(46);
        Lista2.Add(47);

        Debug.Log("NUEVA LISTA");
        Mezcla2();
    }

    // Update is called once per frame
    void Mezcla2()
    {
        foreach (int numeros1 in Lista1)
        {
            Debug.Log(numeros1);
        }

        foreach (int numeros2 in Lista2)
        {
            Debug.Log(numeros2);
        }
        
    }
}
