/*
DESARROLLADOR: Estefannia Lizzet Garcia Zepeda
ASIGNATURA: Estructura de Datos 
PROFESOR: Josue Israel Rivas Diaz
DESCRIPCIÓN: Este script tiene el objeto principal de mover a nuestro protagonista:Pete en las direcciones izquierda, derecha, abajo y saltar.
    
    Tip de movimiento extra con las flechas: Youtube - Colisiones y Disparadores - Minuto 2:36 - Recuperado de:https://www.youtube.com/watch?v=Bc9lmHjqLZc&t=330s
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MuevePete : MonoBehaviour
{
    //Colocamos una variable flotante llamada Velocidad para determinar a que ritmo se desplazara Pete
    public float Velocidad = 5;
    public float jumpForce = 3;
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //Esta seccion corresponde a la asignación de 4 teclas diferentes para cada direccion de movimiento de Pete.
        //Puede moverse presionando las letras o las flechas
        
        if(Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow)) 
        {
            transform.position += Vector3.left *Velocidad*Time.deltaTime;
        }

        if(Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += Vector3.right *Velocidad*Time.deltaTime;
        }

        if(Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            transform.position += Vector3.down *Velocidad*Time.deltaTime;
        }

        /*
        En el caso de la tecla para subir, como tiene la gravedad el peso no deja que salte muy alto, por lo que invocamos al rigidbody y le ponemos un impulso
        ds
        */

        if(Input.GetKeyUp(KeyCode.W))
        {
           rb.AddForce(Vector3.up *jumpForce,ForceMode2D.Impulse);
        }
    }
} //Fin de la clase
