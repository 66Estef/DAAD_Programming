using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Suma : MonoBehaviour
{
    List<int> numeros = new List<int>();
    public int mas;
    // Start is called before the first frame update
    void Start()
    {
        numeros.Add(7);
        numeros.Add(13);
        numeros.Add(22);
        numeros.Add(30);
        numeros.Add(33);

        Sumarnumeros();
    }

    // Update is called once per frame
    void Sumarnumeros()
    {
        foreach (int n in numeros)
        {
            mas = mas + n;
            Debug.Log(mas);
        }

    }
}
