using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class E1 : MonoBehaviour
{
    public TextMeshProUGUI texto;
    private string dato;
    public TMP_InputField componenteInput;
    // Start is called before the first frame update
    void Start()
    {
        IngresarDato();

        if(Input.GetKeyDown(KeyCode.Space))
        {
            AlgoritmoEjercicio();
        }
    }

    // Update is called once per frame
    void AlgoritmoEjercicio()
    {
        texto.text = "BIENVENIDO/A:" + dato;
    }

    void IngresarDato()
    {
        dato = componenteInput.text;
    }
}
