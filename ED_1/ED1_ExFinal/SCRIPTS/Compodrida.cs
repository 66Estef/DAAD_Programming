/*
DESARROLLADOR: Estefannia Lizzet Garcia Zepeda
ASIGNATURA: Estructura de Datos
PROFESOR: Josue Israel Rivas Diaz
DESCRIPCIÓN: Este scrip es para que la comida podrida le reste una vida al jugador
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Compodrida : MonoBehaviour
{
    public int Vida = 5;
    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.tag =="Jugador")
        {
            Vida--;
            Destroy(this.gameObject);
        }

    }

}
