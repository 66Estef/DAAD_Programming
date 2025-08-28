/*
DESARROLLADOR: Estefannia Lizzet Garcia Zepeda
ASIGNATURA: Estructura de Datos
PROFESOR: Josue Israel Rivas Diaz
DESCRIPCIÓN: Este pequeño script es para una nueva ubicacion del personaje en otro continente
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NuevaposP : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        //Como desarrollador podras ponerlo en la posicion 0,0 pero cuando el jugador de Play estara en otro extremo.
        transform.position = new Vector3(-8f,2.6f,0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
