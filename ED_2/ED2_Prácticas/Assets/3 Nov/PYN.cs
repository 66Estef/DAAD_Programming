using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PYN : MonoBehaviour
{
    public int n;
    // Start is called before the first frame update
    void Start()
    {
        for(n = 1; n <= 5; n++)
        {
            Debug.Log(n);
            Debug.Log(-n);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
