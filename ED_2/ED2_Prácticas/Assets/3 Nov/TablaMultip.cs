using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TablaMultip : MonoBehaviour
{
    public int numeroDe;
    public int En;
    public int Hastanum;
    // Start is called before the first frame update
    void Start()
    {
        
        for(numeroDe = 0; numeroDe <= Hastanum; numeroDe++)
        {
            Debug.Log(En * numeroDe);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
