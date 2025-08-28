/*
DESARROLLADOR: Estefannia Lizzet Garcia Zepeda
ASIGNATURA: Estructura de Datos
PROFESOR: Josue Israel Rivas Diaz
DESCRIPCIÓN: Este scrip es para definir el movimiento / la ruta que seguira la bala,
      sin el se quedaria estatica y saldrian muchas pero sin moverse y juntandose en el cañon
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovBala : MonoBehaviour
{
    //Inicio de clase

    //Velocidad a la que se desplaza la bala
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Se dirigira en linea recta a la izquierda multiplicada por la velocidad
        transform.Translate(Vector3.left*speed*Time.deltaTime);
    }
}
