using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EDOS : MonoBehaviour
{
    private int n;
    // Start is called before the first frame update
    void Start()
    {
       for(n = 101; n >= 81; n-=2)
       {
        Debug.Log(-n);
       }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
