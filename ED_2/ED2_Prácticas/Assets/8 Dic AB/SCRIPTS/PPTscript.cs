using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PPTscript : MonoBehaviour
{
    
    public int Piedra = 1;
    public int Papel = 2;
    public int Tijeras = 3;

    public TextMeshProUGUI texto;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void EscogePiedra()
    {
        texto.text = "Ganaste";
    }
}
