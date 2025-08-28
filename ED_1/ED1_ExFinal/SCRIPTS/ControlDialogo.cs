/*
DESARROLLADOR: Estefannia Lizzet Garcia Zepeda
ASIGNATURA: Estructura de Datos 
PROFESOR: Josue Israel Rivas Diaz
DESCRIPCIÓN: Este script tiene la función de controlar el orden en que apareceran los dialogos y bajo que accion del teclado o mouse.
    Tema visto en clase
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ControlDialogo : MonoBehaviour
{
    //Inicio clase

    //Hacemos referencia al script anterior con el que creamos el item
    public DialogosBase dialogo;
    //Contador para el indice de dialogos
    int indice;
    //Texto para que lo pueda ver el usuario
    public TextMeshProUGUI textoDialogo;
    
    // Start is called before the first frame update
    void Start()
    {
        //Aqui le indicamos que empiece en el dialogo con posiicon 0
        textoDialogo.text = dialogo.GetDialogos(0);
    }

    // Update is called once per frame
    void Update()
    {
        //Cada vez que presiones clic con el mouse
        if(Input.GetMouseButtonDown(0))
        {
            //El indice aumentara, y por lo tanto pasara al sig. dialogo
            indice++;
            if(indice >= dialogo.DialogosLenght())
            {
                indice = dialogo.DialogosLenght()-1;
            }

            textoDialogo.text = dialogo.GetDialogos(indice);
        }
    }
}
