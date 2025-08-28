using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Conversación : MonoBehaviour
{
    public string[]respuestas;
    public string[]preguntas;
    public int Indice = 0;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(preguntas[Indice]);
        Debug.Log(respuestas[Indice]);
    }

    // Update is called once per frame
    void Update()
    {   
        if(Input.GetKeyDown(KeyCode.S))
        {
            SiguientePreg();
        }
    }

    void SiguientePreg()
    {
        Indice++;
        if(Indice >= preguntas.Length)
        {
            Debug.Log("FIN DE LAS PREGUNTAS");
        }
    }
}
